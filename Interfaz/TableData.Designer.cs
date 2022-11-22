namespace Asterix_Decoder
{
    partial class TableData
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



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2PanelDT = new Guna.UI2.WinForms.Guna2Panel();
            this.iconBtnFlecha = new FontAwesome.Sharp.IconButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBtnDTMax = new FontAwesome.Sharp.IconButton();
            this.iconBtnDTClose = new FontAwesome.Sharp.IconButton();
            this.dataGridDT = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PanelDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDT)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PanelDT
            // 
            this.guna2PanelDT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.guna2PanelDT.Controls.Add(this.iconBtnFlecha);
            this.guna2PanelDT.Controls.Add(this.btnFiltrar);
            this.guna2PanelDT.Controls.Add(this.textBoxSearch);
            this.guna2PanelDT.Controls.Add(this.iconPictureBoxSearch);
            this.guna2PanelDT.Controls.Add(this.btnSearch);
            this.guna2PanelDT.Controls.Add(this.iconButton1);
            this.guna2PanelDT.Controls.Add(this.iconBtnDTMax);
            this.guna2PanelDT.Controls.Add(this.iconBtnDTClose);
            this.guna2PanelDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelDT.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelDT.Name = "guna2PanelDT";
            this.guna2PanelDT.Size = new System.Drawing.Size(1140, 65);
            this.guna2PanelDT.TabIndex = 0;
            // 
            // iconBtnFlecha
            // 
            this.iconBtnFlecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnFlecha.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconBtnFlecha.IconColor = System.Drawing.Color.Black;
            this.iconBtnFlecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnFlecha.IconSize = 25;
            this.iconBtnFlecha.Location = new System.Drawing.Point(589, 10);
            this.iconBtnFlecha.Name = "iconBtnFlecha";
            this.iconBtnFlecha.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconBtnFlecha.Size = new System.Drawing.Size(45, 45);
            this.iconBtnFlecha.TabIndex = 13;
            this.iconBtnFlecha.UseVisualStyleBackColor = true;
            this.iconBtnFlecha.MouseEnter += new System.EventHandler(this.iconBtnFlecha_MouseEnter);
            this.iconBtnFlecha.MouseLeave += new System.EventHandler(this.iconBtnFlecha_MouseLeave);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(523, 10);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(60, 45);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filter";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(87, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 31);
            this.textBoxSearch.TabIndex = 2;
            // 
            // iconPictureBoxSearch
            // 
            this.iconPictureBoxSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBoxSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearch.IconSize = 45;
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(31, 10);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBoxSearch.TabIndex = 2;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1005, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(45, 65);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconBtnDTMax
            // 
            this.iconBtnDTMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnDTMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDTMax.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.iconBtnDTMax.IconColor = System.Drawing.Color.Black;
            this.iconBtnDTMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDTMax.IconSize = 30;
            this.iconBtnDTMax.Location = new System.Drawing.Point(1050, 0);
            this.iconBtnDTMax.Name = "iconBtnDTMax";
            this.iconBtnDTMax.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.iconBtnDTMax.Size = new System.Drawing.Size(45, 65);
            this.iconBtnDTMax.TabIndex = 3;
            this.iconBtnDTMax.UseVisualStyleBackColor = true;
            this.iconBtnDTMax.Click += new System.EventHandler(this.iconBtnDTMax_Click);
            // 
            // iconBtnDTClose
            // 
            this.iconBtnDTClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnDTClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDTClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconBtnDTClose.IconColor = System.Drawing.Color.Black;
            this.iconBtnDTClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDTClose.IconSize = 25;
            this.iconBtnDTClose.Location = new System.Drawing.Point(1095, 0);
            this.iconBtnDTClose.Name = "iconBtnDTClose";
            this.iconBtnDTClose.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconBtnDTClose.Size = new System.Drawing.Size(45, 65);
            this.iconBtnDTClose.TabIndex = 11;
            this.iconBtnDTClose.UseVisualStyleBackColor = true;
            this.iconBtnDTClose.Click += new System.EventHandler(this.iconBtnDTClose_Click);
            // 
            // dataGridDT
            // 
            this.dataGridDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDT.Location = new System.Drawing.Point(25, 90);
            this.dataGridDT.Name = "dataGridDT";
            this.dataGridDT.RowHeadersWidth = 62;
            this.dataGridDT.RowTemplate.Height = 33;
            this.dataGridDT.Size = new System.Drawing.Size(1090, 585);
            this.dataGridDT.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelFilter.Controls.Add(this.button2);
            this.panelFilter.Controls.Add(this.button1);
            this.panelFilter.Location = new System.Drawing.Point(523, 61);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(213, 101);
            this.panelFilter.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2PanelDT;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // TableData
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 700);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridDT);
            this.Controls.Add(this.guna2PanelDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableData";
            this.Load += new System.EventHandler(this.TableData_Load);
            this.guna2PanelDT.ResumeLayout(false);
            this.guna2PanelDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDT)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel guna2PanelDT;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconBtnDTClose;
        private FontAwesome.Sharp.IconButton iconBtnDTMax;
        private Button btnSearch;
        private DataGridView dataGridDT;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private TextBox textBoxSearch;
        private Button btnFiltrar;
        private FontAwesome.Sharp.IconButton iconBtnFlecha;
        private Panel panelFilter;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}