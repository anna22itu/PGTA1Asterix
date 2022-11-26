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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.BtnPlay = new FontAwesome.Sharp.IconButton();
            this.BtnParar = new FontAwesome.Sharp.IconButton();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.textBoxLAT = new System.Windows.Forms.TextBox();
            this.dataGridViewInfoAircraft = new System.Windows.Forms.DataGridView();
            this.labelInfoAircraft = new System.Windows.Forms.Label();
            this.labelAicraft = new System.Windows.Forms.Label();
            this.textBoxAircraft = new System.Windows.Forms.TextBox();
            this.btnClearAicraft = new System.Windows.Forms.Button();
            this.pictureBoxMapaDifuminado = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelMENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapaDifuminado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadFile.Location = new System.Drawing.Point(56, 84);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(84, 32);
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
            this.BtnExportFile.Size = new System.Drawing.Size(84, 32);
            this.BtnExportFile.TabIndex = 4;
            this.BtnExportFile.Text = "EXPORT FILE";
            this.BtnExportFile.UseVisualStyleBackColor = true;
            this.BtnExportFile.Click += new System.EventHandler(this.BtnExportFile_Click);
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMENU.Controls.Add(this.pictureBox3);
            this.panelMENU.Controls.Add(this.pictureBox2);
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
            this.panelMENU.Size = new System.Drawing.Size(154, 519);
            this.panelMENU.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AsterixDecoder.Properties.Resources.loadinggif;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(14, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.Location = new System.Drawing.Point(14, 168);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.iconPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox6.TabIndex = 9;
            this.iconPictureBox6.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(56, 478);
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
            this.BtnDataView.Size = new System.Drawing.Size(84, 32);
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
            this.iconPictureBox4.Location = new System.Drawing.Point(14, 252);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
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
            this.iconPictureBox5.Location = new System.Drawing.Point(14, 478);
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
            this.BtnAboutUs.Size = new System.Drawing.Size(84, 32);
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
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 210);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
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
            this.iconPictureBox3.Location = new System.Drawing.Point(14, 126);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 13;
            this.iconPictureBox3.TabStop = false;
            // 
            // BtnMapView
            // 
            this.BtnMapView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMapView.Location = new System.Drawing.Point(56, 210);
            this.BtnMapView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMapView.Name = "BtnMapView";
            this.BtnMapView.Size = new System.Drawing.Size(84, 32);
            this.BtnMapView.TabIndex = 8;
            this.BtnMapView.Text = "MAP VIEW";
            this.BtnMapView.UseVisualStyleBackColor = true;
            this.BtnMapView.Click += new System.EventHandler(this.BtnMapView_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(14, 84);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
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
            this.panelBarraArriba.Size = new System.Drawing.Size(942, 39);
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
            this.iconBtnMinus.Location = new System.Drawing.Point(846, 0);
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
            this.iconBtnMaximize.Location = new System.Drawing.Point(878, 0);
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
            this.iconBtnCross.Location = new System.Drawing.Point(910, 0);
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
            this.labelHora.Location = new System.Drawing.Point(970, 68);
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
            // gMapControl1
            // 
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(413, 105);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(651, 336);
            this.gMapControl1.TabIndex = 9;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // BtnPlay
            // 
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.BtnPlay.IconColor = System.Drawing.Color.Black;
            this.BtnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPlay.IconSize = 40;
            this.BtnPlay.Location = new System.Drawing.Point(711, 466);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.BtnPlay.Size = new System.Drawing.Size(32, 27);
            this.BtnPlay.TabIndex = 10;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnParar.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.BtnParar.IconColor = System.Drawing.Color.Black;
            this.BtnParar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnParar.IconSize = 40;
            this.BtnParar.Location = new System.Drawing.Point(711, 466);
            this.BtnParar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(32, 27);
            this.BtnParar.TabIndex = 11;
            this.BtnParar.UseVisualStyleBackColor = true;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(494, 76);
            this.labelLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(57, 15);
            this.labelLat.TabIndex = 12;
            this.labelLat.Text = "LATITUDE";
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(695, 76);
            this.labelLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(70, 15);
            this.labelLong.TabIndex = 13;
            this.labelLong.Text = "LONGITUDE";
            // 
            // textBoxLong
            // 
            this.textBoxLong.Location = new System.Drawing.Point(774, 74);
            this.textBoxLong.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.Size = new System.Drawing.Size(106, 23);
            this.textBoxLong.TabIndex = 14;
            // 
            // textBoxLAT
            // 
            this.textBoxLAT.Location = new System.Drawing.Point(561, 72);
            this.textBoxLAT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLAT.Name = "textBoxLAT";
            this.textBoxLAT.Size = new System.Drawing.Size(106, 23);
            this.textBoxLAT.TabIndex = 15;
            // 
            // dataGridViewInfoAircraft
            // 
            this.dataGridViewInfoAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoAircraft.Location = new System.Drawing.Point(182, 195);
            this.dataGridViewInfoAircraft.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInfoAircraft.Name = "dataGridViewInfoAircraft";
            this.dataGridViewInfoAircraft.RowHeadersWidth = 62;
            this.dataGridViewInfoAircraft.RowTemplate.Height = 33;
            this.dataGridViewInfoAircraft.Size = new System.Drawing.Size(210, 193);
            this.dataGridViewInfoAircraft.TabIndex = 16;
            // 
            // labelInfoAircraft
            // 
            this.labelInfoAircraft.AutoSize = true;
            this.labelInfoAircraft.Location = new System.Drawing.Point(176, 174);
            this.labelInfoAircraft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoAircraft.Name = "labelInfoAircraft";
            this.labelInfoAircraft.Size = new System.Drawing.Size(213, 15);
            this.labelInfoAircraft.TabIndex = 17;
            this.labelInfoAircraft.Text = "Information about the selected aircraft:";
            // 
            // labelAicraft
            // 
            this.labelAicraft.AutoSize = true;
            this.labelAicraft.Location = new System.Drawing.Point(182, 61);
            this.labelAicraft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAicraft.Name = "labelAicraft";
            this.labelAicraft.Size = new System.Drawing.Size(93, 15);
            this.labelAicraft.TabIndex = 18;
            this.labelAicraft.Text = "Selected Aircraft";
            // 
            // textBoxAircraft
            // 
            this.textBoxAircraft.Location = new System.Drawing.Point(176, 84);
            this.textBoxAircraft.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAircraft.Name = "textBoxAircraft";
            this.textBoxAircraft.Size = new System.Drawing.Size(106, 23);
            this.textBoxAircraft.TabIndex = 19;
            // 
            // btnClearAicraft
            // 
            this.btnClearAicraft.Location = new System.Drawing.Point(182, 391);
            this.btnClearAicraft.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAicraft.Name = "btnClearAicraft";
            this.btnClearAicraft.Size = new System.Drawing.Size(99, 20);
            this.btnClearAicraft.TabIndex = 20;
            this.btnClearAicraft.Text = "Clear Selection";
            this.btnClearAicraft.UseVisualStyleBackColor = true;
            this.btnClearAicraft.Click += new System.EventHandler(this.btnClearAicraft_Click);
            // 
            // pictureBoxMapaDifuminado
            // 
            this.pictureBoxMapaDifuminado.Image = global::AsterixDecoder.Properties.Resources.imageMAPA;
            this.pictureBoxMapaDifuminado.Location = new System.Drawing.Point(413, 105);
            this.pictureBoxMapaDifuminado.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMapaDifuminado.Name = "pictureBoxMapaDifuminado";
            this.pictureBoxMapaDifuminado.Size = new System.Drawing.Size(651, 336);
            this.pictureBoxMapaDifuminado.TabIndex = 21;
            this.pictureBoxMapaDifuminado.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AsterixDecoder.Properties.Resources.loadinggif;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(14, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 519);
            this.Controls.Add(this.pictureBoxMapaDifuminado);
            this.Controls.Add(this.btnClearAicraft);
            this.Controls.Add(this.textBoxAircraft);
            this.Controls.Add(this.labelAicraft);
            this.Controls.Add(this.labelInfoAircraft);
            this.Controls.Add(this.dataGridViewInfoAircraft);
            this.Controls.Add(this.textBoxLAT);
            this.Controls.Add(this.textBoxLong);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panelMENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.panelMENU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapaDifuminado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private FontAwesome.Sharp.IconButton BtnPlay;
        private FontAwesome.Sharp.IconButton BtnParar;
        private Label labelLat;
        private Label labelLong;
        private TextBox textBoxLong;
        private TextBox textBoxLAT;
        private DataGridView dataGridViewInfoAircraft;
        private Label labelInfoAircraft;
        private Label labelAicraft;
        private TextBox textBoxAircraft;
        private Button btnClearAicraft;
        private PictureBox pictureBoxMapaDifuminado;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
    }
}
