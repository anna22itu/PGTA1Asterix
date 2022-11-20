﻿namespace Interfaz
{
    partial class MENU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #endregion

        private OpenFileDialog openFileDialog1;
        private Button BtnLoadFile;
        private Button BtnExportFile;
        private Panel panelMENU;
        private Panel panel1;
        private Button BtnMapView;
        private Button BtnAboutUs;
        private Button BtnDataView;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Button BtnExit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.BtnExportFile = new System.Windows.Forms.Button();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDataView = new System.Windows.Forms.Button();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnAboutUs = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMapView = new System.Windows.Forms.Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrentFilenameResponse = new System.Windows.Forms.Label();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.iconBtnMenuBars = new FontAwesome.Sharp.IconButton();
            this.labelHora = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.panelMENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadFile.Location = new System.Drawing.Point(80, 140);
            this.BtnLoadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(120, 45);
            this.BtnLoadFile.TabIndex = 3;
            this.BtnLoadFile.Text = "OPEN FILE";
            this.BtnLoadFile.UseVisualStyleBackColor = false;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // BtnExportFile
            // 
            this.BtnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportFile.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExportFile.Location = new System.Drawing.Point(80, 210);
            this.BtnExportFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExportFile.Name = "BtnExportFile";
            this.BtnExportFile.Size = new System.Drawing.Size(120, 45);
            this.BtnExportFile.TabIndex = 4;
            this.BtnExportFile.Text = "EXPORT FILE";
            this.BtnExportFile.UseVisualStyleBackColor = true;
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMENU.Controls.Add(this.iconPictureBox6);
            this.panelMENU.Controls.Add(this.BtnExit);
            this.panelMENU.Controls.Add(this.BtnDataView);
            this.panelMENU.Controls.Add(this.BtnExportFile);
            this.panelMENU.Controls.Add(this.iconPictureBox4);
            this.panelMENU.Controls.Add(this.iconPictureBox5);
            this.panelMENU.Controls.Add(this.panel2);
            this.panelMENU.Controls.Add(this.BtnAboutUs);
            this.panelMENU.Controls.Add(this.iconPictureBox1);
            this.panelMENU.Controls.Add(this.iconPictureBox3);
            this.panelMENU.Controls.Add(this.BtnLoadFile);
            this.panelMENU.Controls.Add(this.BtnMapView);
            this.panelMENU.Controls.Add(this.iconPictureBox2);
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMENU.Location = new System.Drawing.Point(0, 0);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(220, 808);
            this.panelMENU.TabIndex = 6;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 45;
            this.iconPictureBox6.Location = new System.Drawing.Point(20, 280);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox6.TabIndex = 9;
            this.iconPictureBox6.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(80, 737);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(120, 45);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnDataView
            // 
            this.BtnDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataView.Location = new System.Drawing.Point(80, 280);
            this.BtnDataView.Name = "BtnDataView";
            this.BtnDataView.Size = new System.Drawing.Size(120, 45);
            this.BtnDataView.TabIndex = 10;
            this.BtnDataView.Text = "DATA VIEW";
            this.BtnDataView.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 45;
            this.iconPictureBox4.Location = new System.Drawing.Point(20, 420);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox4.TabIndex = 14;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 45;
            this.iconPictureBox5.Location = new System.Drawing.Point(20, 737);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox5.TabIndex = 8;
            this.iconPictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 90);
            this.panel2.TabIndex = 11;
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox7.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 60;
            this.iconPictureBox7.Location = new System.Drawing.Point(15, 15);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(190, 60);
            this.iconPictureBox7.TabIndex = 8;
            this.iconPictureBox7.TabStop = false;
            // 
            // BtnAboutUs
            // 
            this.BtnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAboutUs.Location = new System.Drawing.Point(80, 420);
            this.BtnAboutUs.Name = "BtnAboutUs";
            this.BtnAboutUs.Size = new System.Drawing.Size(120, 45);
            this.BtnAboutUs.TabIndex = 9;
            this.BtnAboutUs.Text = "ABOUT US";
            this.BtnAboutUs.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(20, 350);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 45;
            this.iconPictureBox3.Location = new System.Drawing.Point(20, 210);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox3.TabIndex = 13;
            this.iconPictureBox3.TabStop = false;
            // 
            // BtnMapView
            // 
            this.BtnMapView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMapView.Location = new System.Drawing.Point(80, 350);
            this.BtnMapView.Name = "BtnMapView";
            this.BtnMapView.Size = new System.Drawing.Size(120, 45);
            this.BtnMapView.TabIndex = 8;
            this.BtnMapView.Text = "MAP VIEW";
            this.BtnMapView.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 45;
            this.iconPictureBox2.Location = new System.Drawing.Point(20, 140);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.labelCurrentFilenameResponse);
            this.panel1.Controls.Add(this.labelCurrentFile);
            this.panel1.Controls.Add(this.iconBtnMenuBars);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 65);
            this.panel1.TabIndex = 7;
            // 
            // labelCurrentFilenameResponse
            // 
            this.labelCurrentFilenameResponse.AutoSize = true;
            this.labelCurrentFilenameResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentFilenameResponse.Location = new System.Drawing.Point(470, 19);
            this.labelCurrentFilenameResponse.Name = "labelCurrentFilenameResponse";
            this.labelCurrentFilenameResponse.Size = new System.Drawing.Size(0, 28);
            this.labelCurrentFilenameResponse.TabIndex = 10;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentFile.Location = new System.Drawing.Point(184, 17);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(256, 28);
            this.labelCurrentFile.TabIndex = 9;
            this.labelCurrentFile.Text = "THE CURRENT FILENAME IS:";
            // 
            // iconBtnMenuBars
            // 
            this.iconBtnMenuBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMenuBars.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconBtnMenuBars.IconColor = System.Drawing.Color.Black;
            this.iconBtnMenuBars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMenuBars.IconSize = 45;
            this.iconBtnMenuBars.Location = new System.Drawing.Point(20, 10);
            this.iconBtnMenuBars.Name = "iconBtnMenuBars";
            this.iconBtnMenuBars.Size = new System.Drawing.Size(45, 45);
            this.iconBtnMenuBars.TabIndex = 8;
            this.iconBtnMenuBars.UseVisualStyleBackColor = true;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.Location = new System.Drawing.Point(1240, 97);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(99, 41);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "HORA";
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1376, 808);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMENU);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MENU";
            this.Text = "MENU";
            this.panelMENU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconButton iconBtnMenuBars;
        private Label labelHora;
        private System.Windows.Forms.Timer Hora;
        private Label labelCurrentFile;
        private Label labelCurrentFilenameResponse;
    }
}