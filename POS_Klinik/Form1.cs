using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;

namespace POS_Klinik
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Klinik;Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
        
        }

      

        private void tbl_KursiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_KursiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_POS_KlinikDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_POS_KlinikDataSet.Tbl_Kursi' table. You can move, or remove it, as needed.
            MuatGridKursi();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MuatGridKursi()
        {
            flpKursi.Controls.Clear();
            String quary = @"SELECT k.IDKursi ,k.NomorKursi,k.StatusKursi,r.NomorAntrian,r.NamaPelanggan,r.JadwalReservasi from Tbl_Kursi k left join Tbl_Reservasi r on k.IDKursi = r.IDKursi order by k.IDKursi ASC";
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                SqlCommand cmd = new SqlCommand(quary,connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                { 
                    Button btn_kursi = new Button();
                    btn_kursi.Width = 85;
                    btn_kursi.Height = 85;
                    btn_kursi.Text = "Kursi" + reader["NomorKursi"].ToString();
                    btn_kursi.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btn_kursi.Margin = new Padding(6);

                    string status = reader["StatusKursi"].ToString();
                    string NoAntrian = reader["NomorAntrian"] != DBNull.Value ? reader["NomorAntrian"].ToString() : "-";
                    string NamaPelanggan = reader ["NamaPelanggan"] != DBNull.Value ? reader["NamaPelanggan"].ToString () : "Tidak ada nama pasien";
                    string jadwal = reader["JadwalReservasi"] != DBNull.Value ? Convert.ToDateTime(reader["JadwalReservasi"]).ToString("dd/MM/yyyy HH:mm") : "-";

                    btn_kursi.Tag = new DetailKursi
                    {
                        IDKursi = Convert.ToInt32(reader["IDKursi"]),
                        NomorKursi = status,
                        NomorAntrian = NoAntrian,
                        NamaPelanggan = NamaPelanggan,
                        JadwalReservasi = jadwal,

                    };
                    if (status.Equals("tersedia", StringComparison.OrdinalIgnoreCase))
                    {
                        btn_kursi.BackColor = Color.LightGreen;
                        btn_kursi.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        btn_kursi.BackColor = Color.LightCoral;
                        btn_kursi.ForeColor = Color.DarkRed;

                    }
                    btn_kursi.Click += btn_kursi_Click;
                    flpKursi.Controls.Add(btn_kursi);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Gagal membaca data relasi: " + ex.Message, "Koneksi Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int idKursiYangDipilih = 0;
        private void btn_kursi_Click (object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if(clickedButton != null && clickedButton.Tag is DetailKursi data)
            {
                idKursiYangDipilih = data.IDKursi;
                lbl_NomorKursi.Text = "Nomor Kursi:" + data.NomorKursi;
                lbl_status.Text = "Status Kursi" + data.StatusKursi;
                lbl_noantri.Text = "No. Antrian" + data.NomorAntrian;
                lbl_Namapelangan.Text = "Nama pasien" + data.NamaPelanggan;
                lbl_jadwal.Text = "jadwal:" + data.JadwalReservasi;
                
            }
        }
        public class DetailKursi
        {
            public int IDKursi { get; set; }
            public string NomorKursi { get; set; }
            public string StatusKursi { get; set; }
            public string NomorAntrian { get; set; }
            public string NamaPelanggan { get; set; }
            public string JadwalReservasi { get; set; }
        }
        private bool TambahReservasi(int idPasien, int idPoli, int idKursi, string noAntrianOtomatis, string namaPelanggan, string qrCodeText)
        {
            if (connect.State == ConnectionState.Closed) connect.Open();
            SqlTransaction transaction = connect.BeginTransaction();

            try
            {
                
                string queryCekPasien = "SELECT COUNT(*) FROM Tbl_Reservasi WHERE IDPasien = @IDPasien";
                SqlCommand cmdCek = new SqlCommand(queryCekPasien, connect, transaction);
                cmdCek.Parameters.AddWithValue("@IDPasien", idPasien);
                if ((int)cmdCek.ExecuteScalar() > 0)
                {
                    transaction.Rollback();
                    MessageBox.Show("Pasien ini sudah memiliki reservasi antrean!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                
                string queryUpdateKursi = "UPDATE Tbl_Kursi SET StatusKursi = 'Terisi' WHERE IDKursi = @IDKursi AND StatusKursi = 'Tersedia'";
                SqlCommand cmdKursi = new SqlCommand(queryUpdateKursi, connect, transaction);
                cmdKursi.Parameters.AddWithValue("@IDKursi", idKursi);
                int terupdate = cmdKursi.ExecuteNonQuery();

                if (terupdate == 0)
                {
                    transaction.Rollback();
                    MessageBox.Show("Kursi sudah terisi/dikunci oleh antrean lain!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string queryInsert = @"INSERT INTO Tbl_Reservasi (IDPasien, IDPoli, IDKursi, NomorAntrian, NamaPelanggan, JadwalReservasi, QRCode) 
                               VALUES (@IDPasien, @IDPoli, @IDKursi, @NomorAntrian, @NamaPelanggan, GETDATE(), @QRCode)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, connect, transaction);
                cmdInsert.Parameters.AddWithValue("@IDPasien", idPasien);
                cmdInsert.Parameters.AddWithValue("@IDPoli", idPoli);
                cmdInsert.Parameters.AddWithValue("@IDKursi", idKursi);
                cmdInsert.Parameters.AddWithValue("@NomorAntrian", noAntrianOtomatis);
                cmdInsert.Parameters.AddWithValue("@NamaPelanggan", namaPelanggan);
                cmdInsert.Parameters.AddWithValue("@QRCode", qrCodeText); 
                cmdInsert.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Reservasi dan QR Code berhasil disimpan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MuatGridKursi();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Kesalahan saat menyimpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txt_namapelangan.Text))
            {
                MessageBox.Show("Silakan isi Nama Pasien dan Nomor Antrean terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (idKursiYangDipilih == 0)
            {
                MessageBox.Show("Silakan klik salah satu kursi terlebih dahulu dari grid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int idPasien = Convert.ToInt32(txt_Idpasien.Text);      
            int idPoli = Convert.ToInt32(txt_idpoli.Text);          
            int idKursi = idKursiYangDipilih;                        
                               
            string namaPelanggan =txt_namapelangan.Text;        
            string noAntrianOtomatis = GenerateNomorAntrianOtomatis(idPoli);
            string stringQRCode = DapatkanStringQRCode(noAntrianOtomatis, idPasien);
          
            bool isSukses = TambahReservasi(idPasien, idPoli, idKursi, noAntrianOtomatis, namaPelanggan, stringQRCode);

            if (isSukses)
            {
                GenerateQRCodeTiket(noAntrianOtomatis, idPasien);

                
               txt_namapelangan.Clear();
               txt_Idpasien.Clear();
                txt_idpoli .Clear();
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private string GenerateNomorAntrianOtomatis(int idPoli)
        {
            string prefix = "ANT-";
            string nomorAntrianBaru = "";

            try
            {
                if (connect.State == ConnectionState.Closed) connect.Open();

                
                string queryGetPrefix = "SELECT KodePoli FROM Tbl_Poli WHERE IDPoli = @IDPoli";
                SqlCommand cmdPrefix = new SqlCommand(queryGetPrefix, connect);
                cmdPrefix.Parameters.AddWithValue("@IDPoli", idPoli);

                object prefixResult = cmdPrefix.ExecuteScalar();
                if (prefixResult != null && prefixResult != DBNull.Value)
                {
                    
                    prefix = prefixResult.ToString().Trim() + "-";
                }

              
                nomorAntrianBaru = prefix + "001";

                
                string queryLastNo = @"SELECT TOP 1 NomorAntrian 
                               FROM Tbl_Reservasi 
                               WHERE IDPoli = @IDPoli 
                                 AND CAST(JadwalReservasi AS DATE) = CAST(GETDATE() AS DATE)
                               ORDER BY IDReservasi DESC";

                SqlCommand cmdLast = new SqlCommand(queryLastNo, connect);
                cmdLast.Parameters.AddWithValue("@IDPoli", idPoli);

                object lastResult = cmdLast.ExecuteScalar();

                if (lastResult != null && lastResult != DBNull.Value)
                {
                    string lastNoAntrian = lastResult.ToString();

                 
                    string angkaStr = lastNoAntrian.Substring(lastNoAntrian.LastIndexOf('-') + 1);
                    int angkaTerakhir = Convert.ToInt32(angkaStr);

                   
                    int angkaBaru = angkaTerakhir + 1;

                   
                    nomorAntrianBaru = prefix + angkaBaru.ToString("D3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal generate nomor antrean otomatis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nomorAntrianBaru;
        }
        private void GenerateQRCodeTiket(string noAntrianOtomatis, int idPasien)
        {
            
            string payload = $"ANTREAN:{noAntrianOtomatis}|PASIEN_ID:{idPasien}";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(5);

          
            picQRCode.Image = qrCodeImage;
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private string DapatkanStringQRCode(string noAntrianOtomatis , int idPasien)
        {
            return $"ANTREAN:{ noAntrianOtomatis }|PASIEN_ID:{idPasien}";
        }
        private void TampilkanQRCodeTiket(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(5);

            picQRCode.Image = qrCodeImage;
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
