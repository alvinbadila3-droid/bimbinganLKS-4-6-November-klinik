namespace POS_Klinik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dB_POS_KlinikDataSet = new POS_Klinik.DB_POS_KlinikDataSet();
            this.tbl_KursiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KursiTableAdapter = new POS_Klinik.DB_POS_KlinikDataSetTableAdapters.Tbl_KursiTableAdapter();
            this.tableAdapterManager = new POS_Klinik.DB_POS_KlinikDataSetTableAdapters.TableAdapterManager();
            this.tbl_KursiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_KursiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.flpKursi = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_NomorKursi = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_noantri = new System.Windows.Forms.Label();
            this.lbl_Namapelangan = new System.Windows.Forms.Label();
            this.lbl_jadwal = new System.Windows.Forms.Label();
            this.txt_namapelangan = new System.Windows.Forms.TextBox();
            this.txt_Idpasien = new System.Windows.Forms.TextBox();
            this.txt_idpoli = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_KlinikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_KursiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_KursiBindingNavigator)).BeginInit();
            this.tbl_KursiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_POS_KlinikDataSet
            // 
            this.dB_POS_KlinikDataSet.DataSetName = "DB_POS_KlinikDataSet";
            this.dB_POS_KlinikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KursiBindingSource
            // 
            this.tbl_KursiBindingSource.DataMember = "Tbl_Kursi";
            this.tbl_KursiBindingSource.DataSource = this.dB_POS_KlinikDataSet;
            // 
            // tbl_KursiTableAdapter
            // 
            this.tbl_KursiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_KursiTableAdapter = this.tbl_KursiTableAdapter;
            this.tableAdapterManager.Tbl_pasienTableAdapter = null;
            this.tableAdapterManager.Tbl_PoliTableAdapter = null;
            this.tableAdapterManager.Tbl_ReservasiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_Klinik.DB_POS_KlinikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_KursiBindingNavigator
            // 
            this.tbl_KursiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_KursiBindingNavigator.BindingSource = this.tbl_KursiBindingSource;
            this.tbl_KursiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_KursiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_KursiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_KursiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_KursiBindingNavigatorSaveItem});
            this.tbl_KursiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_KursiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_KursiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_KursiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_KursiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_KursiBindingNavigator.Name = "tbl_KursiBindingNavigator";
            this.tbl_KursiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_KursiBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.tbl_KursiBindingNavigator.TabIndex = 0;
            this.tbl_KursiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbl_KursiBindingNavigatorSaveItem
            // 
            this.tbl_KursiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_KursiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_KursiBindingNavigatorSaveItem.Image")));
            this.tbl_KursiBindingNavigatorSaveItem.Name = "tbl_KursiBindingNavigatorSaveItem";
            this.tbl_KursiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbl_KursiBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_KursiBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_KursiBindingNavigatorSaveItem_Click);
            // 
            // flpKursi
            // 
            this.flpKursi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpKursi.Location = new System.Drawing.Point(13, 49);
            this.flpKursi.Name = "flpKursi";
            this.flpKursi.Size = new System.Drawing.Size(394, 389);
            this.flpKursi.TabIndex = 1;
            this.flpKursi.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lbl_NomorKursi
            // 
            this.lbl_NomorKursi.AutoSize = true;
            this.lbl_NomorKursi.Location = new System.Drawing.Point(428, 35);
            this.lbl_NomorKursi.Name = "lbl_NomorKursi";
            this.lbl_NomorKursi.Size = new System.Drawing.Size(80, 16);
            this.lbl_NomorKursi.TabIndex = 2;
            this.lbl_NomorKursi.Text = "Nomor Kursi";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(428, 64);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(76, 16);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status Kursi";
            // 
            // lbl_noantri
            // 
            this.lbl_noantri.AutoSize = true;
            this.lbl_noantri.Location = new System.Drawing.Point(428, 93);
            this.lbl_noantri.Name = "lbl_noantri";
            this.lbl_noantri.Size = new System.Drawing.Size(77, 16);
            this.lbl_noantri.TabIndex = 4;
            this.lbl_noantri.Text = "No. Antrean";
            // 
            // lbl_Namapelangan
            // 
            this.lbl_Namapelangan.AutoSize = true;
            this.lbl_Namapelangan.Location = new System.Drawing.Point(428, 122);
            this.lbl_Namapelangan.Name = "lbl_Namapelangan";
            this.lbl_Namapelangan.Size = new System.Drawing.Size(92, 16);
            this.lbl_Namapelangan.TabIndex = 5;
            this.lbl_Namapelangan.Text = "Nama Pasien:";
            // 
            // lbl_jadwal
            // 
            this.lbl_jadwal.AutoSize = true;
            this.lbl_jadwal.Location = new System.Drawing.Point(428, 150);
            this.lbl_jadwal.Name = "lbl_jadwal";
            this.lbl_jadwal.Size = new System.Drawing.Size(50, 16);
            this.lbl_jadwal.TabIndex = 6;
            this.lbl_jadwal.Text = "Jadwal";
            // 
            // txt_namapelangan
            // 
            this.txt_namapelangan.Location = new System.Drawing.Point(431, 195);
            this.txt_namapelangan.Name = "txt_namapelangan";
            this.txt_namapelangan.Size = new System.Drawing.Size(195, 22);
            this.txt_namapelangan.TabIndex = 7;
            // 
            // txt_Idpasien
            // 
            this.txt_Idpasien.Location = new System.Drawing.Point(431, 245);
            this.txt_Idpasien.Name = "txt_Idpasien";
            this.txt_Idpasien.Size = new System.Drawing.Size(195, 22);
            this.txt_Idpasien.TabIndex = 8;
            // 
            // txt_idpoli
            // 
            this.txt_idpoli.Location = new System.Drawing.Point(431, 295);
            this.txt_idpoli.Name = "txt_idpoli";
            this.txt_idpoli.Size = new System.Drawing.Size(89, 22);
            this.txt_idpoli.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(445, 349);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "button1";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(575, 286);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(198, 139);
            this.picQRCode.TabIndex = 11;
            this.picQRCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "nama  pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "IDpasien";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "IDPoli";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txt_idpoli);
            this.Controls.Add(this.txt_Idpasien);
            this.Controls.Add(this.txt_namapelangan);
            this.Controls.Add(this.lbl_jadwal);
            this.Controls.Add(this.lbl_Namapelangan);
            this.Controls.Add(this.lbl_noantri);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_NomorKursi);
            this.Controls.Add(this.flpKursi);
            this.Controls.Add(this.tbl_KursiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_KlinikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_KursiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_KursiBindingNavigator)).EndInit();
            this.tbl_KursiBindingNavigator.ResumeLayout(false);
            this.tbl_KursiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_POS_KlinikDataSet dB_POS_KlinikDataSet;
        private System.Windows.Forms.BindingSource tbl_KursiBindingSource;
        private DB_POS_KlinikDataSetTableAdapters.Tbl_KursiTableAdapter tbl_KursiTableAdapter;
        private DB_POS_KlinikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_KursiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_KursiBindingNavigatorSaveItem;
        private System.Windows.Forms.FlowLayoutPanel flpKursi;
        private System.Windows.Forms.Label lbl_NomorKursi;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_noantri;
        private System.Windows.Forms.Label lbl_Namapelangan;
        private System.Windows.Forms.Label lbl_jadwal;
        private System.Windows.Forms.TextBox txt_namapelangan;
        private System.Windows.Forms.TextBox txt_Idpasien;
        private System.Windows.Forms.TextBox txt_idpoli;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

