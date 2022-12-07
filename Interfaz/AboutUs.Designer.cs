namespace AsterixDecoder
{
    partial class AboutUs
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseAU = new System.Windows.Forms.Button();
            this.iconPictureBoxPerson1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPerson1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 155);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "We are in our last year at the UPC (EETAC). ";
            // 
            // btnCloseAU
            // 
            this.btnCloseAU.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCloseAU.Location = new System.Drawing.Point(240, 265);
            this.btnCloseAU.Name = "btnCloseAU";
            this.btnCloseAU.Size = new System.Drawing.Size(112, 34);
            this.btnCloseAU.TabIndex = 1;
            this.btnCloseAU.Text = "Close";
            this.btnCloseAU.UseVisualStyleBackColor = false;
            this.btnCloseAU.Click += new System.EventHandler(this.btnCloseAU_Click);
            // 
            // iconPictureBoxPerson1
            // 
            this.iconPictureBoxPerson1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconPictureBoxPerson1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxPerson1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBoxPerson1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxPerson1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxPerson1.IconSize = 59;
            this.iconPictureBoxPerson1.Location = new System.Drawing.Point(22, 14);
            this.iconPictureBoxPerson1.Name = "iconPictureBoxPerson1";
            this.iconPictureBoxPerson1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconPictureBoxPerson1.Size = new System.Drawing.Size(63, 59);
            this.iconPictureBoxPerson1.TabIndex = 2;
            this.iconPictureBoxPerson1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to our simulator!! ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "We are Alex and Anna, two aerospace engineering students. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "We hope you enjoyed this simulator!";
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBoxPerson1);
            this.Controls.Add(this.btnCloseAU);
            this.Controls.Add(this.label1);
            this.Name = "AboutUs";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPerson1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCloseAU;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxPerson1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}