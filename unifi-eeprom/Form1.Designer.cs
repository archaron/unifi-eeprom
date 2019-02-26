namespace unifi_eeprom
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLock = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWLAN = new System.Windows.Forms.TextBox();
            this.tbLAN2 = new System.Windows.Forms.TextBox();
            this.tbLAN1 = new System.Windows.Forms.TextBox();
            this.tbAntenna = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCRC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewCRC = new System.Windows.Forms.TextBox();
            this.tbCRC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxModel2 = new System.Windows.Forms.ComboBox();
            this.cbxModel1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSubDevice1 = new System.Windows.Forms.TextBox();
            this.tbDevice1 = new System.Windows.Forms.TextBox();
            this.tbSubDevice2 = new System.Windows.Forms.TextBox();
            this.tbDevice2 = new System.Windows.Forms.TextBox();
            this.tbSubVendor1 = new System.Windows.Forms.TextBox();
            this.tbSubVendor2 = new System.Windows.Forms.TextBox();
            this.tbRev2 = new System.Windows.Forms.TextBox();
            this.tbRev1 = new System.Windows.Forms.TextBox();
            this.tbVendor1 = new System.Windows.Forms.TextBox();
            this.tbVendor2 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bin";
            this.openFileDialog1.FileName = "fullflash";
            this.openFileDialog1.Filter = "Образ FLASH UBNT|*.bin|Все файлы|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл FullFlash";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(459, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(138, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Выбрать файл FF";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 17);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLock);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbWLAN);
            this.groupBox2.Controls.Add(this.tbLAN2);
            this.groupBox2.Controls.Add(this.tbLAN1);
            this.groupBox2.Controls.Add(this.tbAntenna);
            this.groupBox2.Controls.Add(this.tbCountry);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCRC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbNewCRC);
            this.groupBox2.Controls.Add(this.tbCRC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о EEPROM";
            // 
            // cbLock
            // 
            this.cbLock.AutoSize = true;
            this.cbLock.Location = new System.Drawing.Point(391, 113);
            this.cbLock.Name = "cbLock";
            this.cbLock.Size = new System.Drawing.Size(118, 17);
            this.cbLock.TabIndex = 18;
            this.cbLock.Text = "Защита counterfeit";
            this.cbLock.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "WLAN MAC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "LAN2 MAC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "LAN1 MAC";
            // 
            // tbWLAN
            // 
            this.tbWLAN.Location = new System.Drawing.Point(462, 85);
            this.tbWLAN.Name = "tbWLAN";
            this.tbWLAN.Size = new System.Drawing.Size(100, 20);
            this.tbWLAN.TabIndex = 16;
            // 
            // tbLAN2
            // 
            this.tbLAN2.Location = new System.Drawing.Point(254, 111);
            this.tbLAN2.Name = "tbLAN2";
            this.tbLAN2.Size = new System.Drawing.Size(100, 20);
            this.tbLAN2.TabIndex = 15;
            // 
            // tbLAN1
            // 
            this.tbLAN1.Location = new System.Drawing.Point(254, 85);
            this.tbLAN1.Name = "tbLAN1";
            this.tbLAN1.Size = new System.Drawing.Size(100, 20);
            this.tbLAN1.TabIndex = 14;
            // 
            // tbAntenna
            // 
            this.tbAntenna.Location = new System.Drawing.Point(56, 111);
            this.tbAntenna.Name = "tbAntenna";
            this.tbAntenna.Size = new System.Drawing.Size(100, 20);
            this.tbAntenna.TabIndex = 13;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(56, 85);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Антенна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Страна";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(511, 25);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(86, 20);
            this.tbSize.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер";
            // 
            // btnCRC
            // 
            this.btnCRC.Location = new System.Drawing.Point(373, 24);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(75, 23);
            this.btnCRC.TabIndex = 7;
            this.btnCRC.Text = "Посчитать CRC";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New CRC";
            // 
            // tbNewCRC
            // 
            this.tbNewCRC.Location = new System.Drawing.Point(254, 25);
            this.tbNewCRC.Name = "tbNewCRC";
            this.tbNewCRC.Size = new System.Drawing.Size(100, 20);
            this.tbNewCRC.TabIndex = 5;
            // 
            // tbCRC
            // 
            this.tbCRC.Location = new System.Drawing.Point(49, 25);
            this.tbCRC.Name = "tbCRC";
            this.tbCRC.Size = new System.Drawing.Size(100, 20);
            this.tbCRC.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CRC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxModel2);
            this.groupBox3.Controls.Add(this.cbxModel1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbSubDevice1);
            this.groupBox3.Controls.Add(this.tbDevice1);
            this.groupBox3.Controls.Add(this.tbSubDevice2);
            this.groupBox3.Controls.Add(this.tbDevice2);
            this.groupBox3.Controls.Add(this.tbSubVendor1);
            this.groupBox3.Controls.Add(this.tbSubVendor2);
            this.groupBox3.Controls.Add(this.tbRev2);
            this.groupBox3.Controls.Add(this.tbRev1);
            this.groupBox3.Controls.Add(this.tbVendor1);
            this.groupBox3.Controls.Add(this.tbVendor2);
            this.groupBox3.Location = new System.Drawing.Point(12, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о железе";
            // 
            // cbxModel2
            // 
            this.cbxModel2.FormattingEnabled = true;
            this.cbxModel2.Location = new System.Drawing.Point(295, 73);
            this.cbxModel2.Name = "cbxModel2";
            this.cbxModel2.Size = new System.Drawing.Size(242, 21);
            this.cbxModel2.TabIndex = 5;
            this.cbxModel2.SelectedIndexChanged += new System.EventHandler(this.cbxModel2_SelectedIndexChanged);
            // 
            // cbxModel1
            // 
            this.cbxModel1.FormattingEnabled = true;
            this.cbxModel1.Location = new System.Drawing.Point(294, 45);
            this.cbxModel1.Name = "cbxModel1";
            this.cbxModel1.Size = new System.Drawing.Size(243, 21);
            this.cbxModel1.TabIndex = 5;
            this.cbxModel1.SelectedIndexChanged += new System.EventHandler(this.cbxModel1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "PCI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "SubVendor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vendor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(540, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Revision";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "SubDevice";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PCI-X";
            // 
            // tbSubDevice1
            // 
            this.tbSubDevice1.Location = new System.Drawing.Point(234, 45);
            this.tbSubDevice1.Name = "tbSubDevice1";
            this.tbSubDevice1.Size = new System.Drawing.Size(54, 20);
            this.tbSubDevice1.TabIndex = 3;
            // 
            // tbDevice1
            // 
            this.tbDevice1.Enabled = false;
            this.tbDevice1.Location = new System.Drawing.Point(112, 45);
            this.tbDevice1.Name = "tbDevice1";
            this.tbDevice1.Size = new System.Drawing.Size(54, 20);
            this.tbDevice1.TabIndex = 3;
            // 
            // tbSubDevice2
            // 
            this.tbSubDevice2.Location = new System.Drawing.Point(235, 73);
            this.tbSubDevice2.Name = "tbSubDevice2";
            this.tbSubDevice2.Size = new System.Drawing.Size(53, 20);
            this.tbSubDevice2.TabIndex = 3;
            // 
            // tbDevice2
            // 
            this.tbDevice2.Enabled = false;
            this.tbDevice2.Location = new System.Drawing.Point(112, 73);
            this.tbDevice2.Name = "tbDevice2";
            this.tbDevice2.Size = new System.Drawing.Size(54, 20);
            this.tbDevice2.TabIndex = 3;
            // 
            // tbSubVendor1
            // 
            this.tbSubVendor1.Enabled = false;
            this.tbSubVendor1.Location = new System.Drawing.Point(172, 45);
            this.tbSubVendor1.Name = "tbSubVendor1";
            this.tbSubVendor1.Size = new System.Drawing.Size(54, 20);
            this.tbSubVendor1.TabIndex = 3;
            // 
            // tbSubVendor2
            // 
            this.tbSubVendor2.Enabled = false;
            this.tbSubVendor2.Location = new System.Drawing.Point(172, 73);
            this.tbSubVendor2.Name = "tbSubVendor2";
            this.tbSubVendor2.Size = new System.Drawing.Size(54, 20);
            this.tbSubVendor2.TabIndex = 3;
            // 
            // tbRev2
            // 
            this.tbRev2.Enabled = false;
            this.tbRev2.Location = new System.Drawing.Point(543, 73);
            this.tbRev2.Name = "tbRev2";
            this.tbRev2.Size = new System.Drawing.Size(54, 20);
            this.tbRev2.TabIndex = 3;

            // 
            // tbRev1
            // 
            this.tbRev1.Enabled = false;
            this.tbRev1.Location = new System.Drawing.Point(543, 45);
            this.tbRev1.Name = "tbRev1";
            this.tbRev1.Size = new System.Drawing.Size(54, 20);
            this.tbRev1.TabIndex = 3;
            // 
            // tbVendor1
            // 
            this.tbVendor1.Enabled = false;
            this.tbVendor1.Location = new System.Drawing.Point(50, 45);
            this.tbVendor1.Name = "tbVendor1";
            this.tbVendor1.Size = new System.Drawing.Size(54, 20);
            this.tbVendor1.TabIndex = 3;
            // 
            // tbVendor2
            // 
            this.tbVendor2.Enabled = false;
            this.tbVendor2.Location = new System.Drawing.Point(50, 73);
            this.tbVendor2.Name = "tbVendor2";
            this.tbVendor2.Size = new System.Drawing.Size(54, 20);
            this.tbVendor2.TabIndex = 3;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 374);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UBNT EEPROM Patcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewCRC;
        private System.Windows.Forms.Button btnCRC;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAntenna;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWLAN;
        private System.Windows.Forms.TextBox tbLAN2;
        private System.Windows.Forms.TextBox tbLAN1;
        private System.Windows.Forms.CheckBox cbLock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbVendor2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSubDevice1;
        private System.Windows.Forms.TextBox tbDevice1;
        private System.Windows.Forms.TextBox tbSubDevice2;
        private System.Windows.Forms.TextBox tbDevice2;
        private System.Windows.Forms.TextBox tbSubVendor1;
        private System.Windows.Forms.TextBox tbSubVendor2;
        private System.Windows.Forms.TextBox tbVendor1;
        private System.Windows.Forms.ComboBox cbxModel2;
        private System.Windows.Forms.ComboBox cbxModel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRev2;
        private System.Windows.Forms.TextBox tbRev1;
    }
}

