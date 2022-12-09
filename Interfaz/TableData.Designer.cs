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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PanelDT = new Guna.UI2.WinForms.Guna2Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBtnDTMax = new FontAwesome.Sharp.IconButton();
            this.iconBtnDTClose = new FontAwesome.Sharp.IconButton();
            this.dataGridDT = new System.Windows.Forms.DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PanelDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDT)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelDT
            // 
            this.guna2PanelDT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.guna2PanelDT.Controls.Add(this.checkBox4);
            this.guna2PanelDT.Controls.Add(this.checkBox3);
            this.guna2PanelDT.Controls.Add(this.checkBox6);
            this.guna2PanelDT.Controls.Add(this.checkBox5);
            this.guna2PanelDT.Controls.Add(this.btnSearch);
            this.guna2PanelDT.Controls.Add(this.checkBox2);
            this.guna2PanelDT.Controls.Add(this.textBoxSearch);
            this.guna2PanelDT.Controls.Add(this.checkBox1);
            this.guna2PanelDT.Controls.Add(this.iconPictureBoxSearch);
            this.guna2PanelDT.Controls.Add(this.iconButton1);
            this.guna2PanelDT.Controls.Add(this.iconBtnDTMax);
            this.guna2PanelDT.Controls.Add(this.iconBtnDTClose);
            this.guna2PanelDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelDT.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelDT.Name = "guna2PanelDT";
            this.guna2PanelDT.Size = new System.Drawing.Size(1289, 65);
            this.guna2PanelDT.TabIndex = 0;
            this.guna2PanelDT.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2PanelDT_Paint);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(554, 33);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(110, 19);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Mode 3/A Code";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox4_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(554, 10);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 19);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Target Address";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(354, 33);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(100, 19);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Track Number";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.checkBox6_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(354, 10);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(131, 19);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Target Identification";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.checkBox5_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1006, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(130, 19);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Show Relevant Data";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(857, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 23);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show All Data";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // iconPictureBoxSearch
            // 
            this.iconPictureBoxSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBoxSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearch.IconSize = 45;
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(806, 10);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBoxSearch.TabIndex = 2;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1154, 0);
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
            this.iconBtnDTMax.Location = new System.Drawing.Point(1199, 0);
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
            this.iconBtnDTClose.Location = new System.Drawing.Point(1244, 0);
            this.iconBtnDTClose.Name = "iconBtnDTClose";
            this.iconBtnDTClose.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconBtnDTClose.Size = new System.Drawing.Size(45, 65);
            this.iconBtnDTClose.TabIndex = 11;
            this.iconBtnDTClose.UseVisualStyleBackColor = true;
            this.iconBtnDTClose.Click += new System.EventHandler(this.iconBtnDTClose_Click);
            // 
            // dataGridDT
            // 
            this.dataGridDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDT.Location = new System.Drawing.Point(25, 90);
            this.dataGridDT.Name = "dataGridDT";
            this.dataGridDT.RowHeadersWidth = 62;
            this.dataGridDT.RowTemplate.Height = 33;
            this.dataGridDT.Size = new System.Drawing.Size(1239, 585);
            this.dataGridDT.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2PanelDT;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show More Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // TableData
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridDT);
            this.Controls.Add(this.guna2PanelDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableData";
            this.Load += new System.EventHandler(this.TableData_Load);
            this.guna2PanelDT.ResumeLayout(false);
            this.guna2PanelDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2Panel guna2PanelDT;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconBtnDTClose;
        private FontAwesome.Sharp.IconButton iconBtnDTMax;
        private Button btnSearch;
        private DataGridView dataGridDT;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Button button1;
        private Label label1;

        public void setLabel1Text(string s)
        {
            label1.Text = "";
            label1.Text = s;
          
        }
    }
}