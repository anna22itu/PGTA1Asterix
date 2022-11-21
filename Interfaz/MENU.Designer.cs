namespace Interfaz
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
        private Button BtnLoadFile;
        private Button BtnExportFile;
        private Panel panelMENU;
        private Panel panelBarraArriba;
        private Button BtnMapView;
        private Button BtnAboutUs;
        private Button BtnDataView;
        private Panel panelIcon;
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
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.BtnExportFile = new System.Windows.Forms.Button();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDataView = new System.Windows.Forms.Button();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAboutUs = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMapView = new System.Windows.Forms.Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.iconBtnMinus = new FontAwesome.Sharp.IconButton();
            this.iconBtnMaximize = new FontAwesome.Sharp.IconButton();
            this.iconBtnCross = new FontAwesome.Sharp.IconButton();
            this.labelCurrentFilenameResponse = new System.Windows.Forms.Label();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.iconBtnMenuBars = new FontAwesome.Sharp.IconButton();
            this.labelHora = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadFile.Location = new System.Drawing.Point(56, 84);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(84, 27);
            this.BtnLoadFile.TabIndex = 3;
            this.BtnLoadFile.Text = "OPEN FILE";
            this.BtnLoadFile.UseVisualStyleBackColor = false;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // BtnExportFile
            // 
            this.BtnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportFile.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExportFile.Location = new System.Drawing.Point(56, 126);
            this.BtnExportFile.Name = "BtnExportFile";
            this.BtnExportFile.Size = new System.Drawing.Size(84, 27);
            this.BtnExportFile.TabIndex = 4;
            this.BtnExportFile.Text = "EXPORT FILE";
            this.BtnExportFile.UseVisualStyleBackColor = true;
            this.BtnExportFile.Click += new System.EventHandler(this.BtnExportFile_Click);
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
            this.panelMENU.Controls.Add(this.panelIcon);
            this.panelMENU.Controls.Add(this.BtnAboutUs);
            this.panelMENU.Controls.Add(this.iconPictureBox1);
            this.panelMENU.Controls.Add(this.iconPictureBox3);
            this.panelMENU.Controls.Add(this.BtnLoadFile);
            this.panelMENU.Controls.Add(this.BtnMapView);
            this.panelMENU.Controls.Add(this.iconPictureBox2);
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMENU.Location = new System.Drawing.Point(0, 0);
            this.panelMENU.Margin = new System.Windows.Forms.Padding(2);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(154, 480);
            this.panelMENU.TabIndex = 6;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 27;
            this.iconPictureBox6.Location = new System.Drawing.Point(14, 168);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconPictureBox6.Size = new System.Drawing.Size(32, 27);
            this.iconPictureBox6.TabIndex = 9;
            this.iconPictureBox6.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(56, 442);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(84, 27);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDataView
            // 
            this.BtnDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataView.Location = new System.Drawing.Point(56, 168);
            this.BtnDataView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDataView.Name = "BtnDataView";
            this.BtnDataView.Size = new System.Drawing.Size(84, 27);
            this.BtnDataView.TabIndex = 10;
            this.BtnDataView.Text = "DATA VIEW";
            this.BtnDataView.UseVisualStyleBackColor = true;
            this.BtnDataView.Click += new System.EventHandler(this.BtnDataView_Click);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 27;
            this.iconPictureBox4.Location = new System.Drawing.Point(14, 252);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 27);
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
            this.iconPictureBox5.IconSize = 27;
            this.iconPictureBox5.Location = new System.Drawing.Point(14, 442);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 27);
            this.iconPictureBox5.TabIndex = 8;
            this.iconPictureBox5.TabStop = false;
            // 
            // panelIcon
            // 
            this.panelIcon.Controls.Add(this.pictureBox1);
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(2);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(154, 66);
            this.panelIcon.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AsterixDecoder.Properties.Resources.AD_3;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAboutUs
            // 
            this.BtnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAboutUs.Location = new System.Drawing.Point(56, 252);
            this.BtnAboutUs.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAboutUs.Name = "BtnAboutUs";
            this.BtnAboutUs.Size = new System.Drawing.Size(84, 27);
            this.BtnAboutUs.TabIndex = 9;
            this.BtnAboutUs.Text = "ABOUT US";
            this.BtnAboutUs.UseVisualStyleBackColor = true;
            this.BtnAboutUs.Click += new System.EventHandler(this.BtnAboutUs_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 210);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 27);
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
            this.iconPictureBox3.IconSize = 27;
            this.iconPictureBox3.Location = new System.Drawing.Point(14, 126);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 27);
            this.iconPictureBox3.TabIndex = 13;
            this.iconPictureBox3.TabStop = false;
            // 
            // BtnMapView
            // 
            this.BtnMapView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMapView.Location = new System.Drawing.Point(56, 210);
            this.BtnMapView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMapView.Name = "BtnMapView";
            this.BtnMapView.Size = new System.Drawing.Size(84, 27);
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
            this.iconPictureBox2.IconSize = 27;
            this.iconPictureBox2.Location = new System.Drawing.Point(14, 84);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 27);
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBarraArriba.Controls.Add(this.iconBtnMinus);
            this.panelBarraArriba.Controls.Add(this.iconBtnMaximize);
            this.panelBarraArriba.Controls.Add(this.iconBtnCross);
            this.panelBarraArriba.Controls.Add(this.labelCurrentFilenameResponse);
            this.panelBarraArriba.Controls.Add(this.labelCurrentFile);
            this.panelBarraArriba.Controls.Add(this.iconBtnMenuBars);
            this.panelBarraArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraArriba.Location = new System.Drawing.Point(154, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(854, 39);
            this.panelBarraArriba.TabIndex = 7;
            // 
            // iconBtnMinus
            // 
            this.iconBtnMinus.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconBtnMinus.IconColor = System.Drawing.Color.Black;
            this.iconBtnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMinus.IconSize = 30;
            this.iconBtnMinus.Location = new System.Drawing.Point(758, 0);
            this.iconBtnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnMinus.Name = "iconBtnMinus";
            this.iconBtnMinus.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.iconBtnMinus.Size = new System.Drawing.Size(32, 39);
            this.iconBtnMinus.TabIndex = 11;
            this.iconBtnMinus.UseVisualStyleBackColor = true;
            this.iconBtnMinus.Click += new System.EventHandler(this.iconBtnMinus_Click);
            // 
            // iconBtnMaximize
            // 
            this.iconBtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconBtnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.iconBtnMaximize.IconColor = System.Drawing.Color.Black;
            this.iconBtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMaximize.IconSize = 30;
            this.iconBtnMaximize.Location = new System.Drawing.Point(790, 0);
            this.iconBtnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnMaximize.Name = "iconBtnMaximize";
            this.iconBtnMaximize.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.iconBtnMaximize.Size = new System.Drawing.Size(32, 39);
            this.iconBtnMaximize.TabIndex = 12;
            this.iconBtnMaximize.UseVisualStyleBackColor = true;
            this.iconBtnMaximize.Click += new System.EventHandler(this.iconBtnMaximize_Click);
            // 
            // iconBtnCross
            // 
            this.iconBtnCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCross.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconBtnCross.IconColor = System.Drawing.Color.Black;
            this.iconBtnCross.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCross.IconSize = 25;
            this.iconBtnCross.Location = new System.Drawing.Point(822, 0);
            this.iconBtnCross.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnCross.Name = "iconBtnCross";
            this.iconBtnCross.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconBtnCross.Size = new System.Drawing.Size(32, 39);
            this.iconBtnCross.TabIndex = 11;
            this.iconBtnCross.UseVisualStyleBackColor = true;
            this.iconBtnCross.Click += new System.EventHandler(this.iconBtnCross_Click);
            // 
            // labelCurrentFilenameResponse
            // 
            this.labelCurrentFilenameResponse.AutoSize = true;
            this.labelCurrentFilenameResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentFilenameResponse.Location = new System.Drawing.Point(329, 11);
            this.labelCurrentFilenameResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentFilenameResponse.Name = "labelCurrentFilenameResponse";
            this.labelCurrentFilenameResponse.Size = new System.Drawing.Size(0, 19);
            this.labelCurrentFilenameResponse.TabIndex = 10;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentFile.Location = new System.Drawing.Point(129, 10);
            this.labelCurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(182, 19);
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
            this.iconBtnMenuBars.Location = new System.Drawing.Point(14, 6);
            this.iconBtnMenuBars.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnMenuBars.Name = "iconBtnMenuBars";
            this.iconBtnMenuBars.Size = new System.Drawing.Size(32, 27);
            this.iconBtnMenuBars.TabIndex = 8;
            this.iconBtnMenuBars.UseVisualStyleBackColor = true;
            this.iconBtnMenuBars.Click += new System.EventHandler(this.iconBtnMenuBars_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.Location = new System.Drawing.Point(892, 60);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(66, 28);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "HORA";
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelBarraArriba;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 480);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panelMENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.panelMENU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private FontAwesome.Sharp.IconButton iconBtnMenuBars;
        private Label labelHora;
        private System.Windows.Forms.Timer Hora;
        private Label labelCurrentFile;
        private Label labelCurrentFilenameResponse;
        private FontAwesome.Sharp.IconButton iconBtnCross;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private FontAwesome.Sharp.IconButton iconBtnMinus;
        private FontAwesome.Sharp.IconButton iconBtnMaximize;
        private PictureBox pictureBox1;
    }
}
