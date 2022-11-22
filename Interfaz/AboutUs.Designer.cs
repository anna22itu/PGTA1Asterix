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
            this.iconPicturePerson2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicturePerson2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 168);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(343, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "We are an engineering aerospace student ";
            // 
            // btnCloseAU
            // 
            this.btnCloseAU.Location = new System.Drawing.Point(263, 285);
            this.btnCloseAU.Name = "btnCloseAU";
            this.btnCloseAU.Size = new System.Drawing.Size(112, 34);
            this.btnCloseAU.TabIndex = 1;
            this.btnCloseAU.Text = "Close";
            this.btnCloseAU.UseVisualStyleBackColor = true;
            this.btnCloseAU.Click += new System.EventHandler(this.btnCloseAU_Click);
            // 
            // iconPictureBoxPerson1
            // 
            this.iconPictureBoxPerson1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxPerson1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxPerson1.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconPictureBoxPerson1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxPerson1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxPerson1.IconSize = 48;
            this.iconPictureBoxPerson1.Location = new System.Drawing.Point(22, 14);
            this.iconPictureBoxPerson1.Name = "iconPictureBoxPerson1";
            this.iconPictureBoxPerson1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconPictureBoxPerson1.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBoxPerson1.TabIndex = 2;
            this.iconPictureBoxPerson1.TabStop = false;
            // 
            // iconPicturePerson2
            // 
            this.iconPicturePerson2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicturePerson2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicturePerson2.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconPicturePerson2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicturePerson2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicturePerson2.IconSize = 48;
            this.iconPicturePerson2.Location = new System.Drawing.Point(76, 14);
            this.iconPicturePerson2.Name = "iconPicturePerson2";
            this.iconPicturePerson2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconPicturePerson2.Size = new System.Drawing.Size(48, 48);
            this.iconPicturePerson2.TabIndex = 4;
            this.iconPicturePerson2.TabStop = false;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 367);
            this.Controls.Add(this.iconPicturePerson2);
            this.Controls.Add(this.iconPictureBoxPerson1);
            this.Controls.Add(this.btnCloseAU);
            this.Controls.Add(this.label1);
            this.Name = "AboutUs";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicturePerson2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCloseAU;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxPerson1;
        private FontAwesome.Sharp.IconPictureBox iconPicturePerson2;
    }
}