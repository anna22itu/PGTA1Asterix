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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somos Alex Gonzalez & Anna Iturralde";
            // 
            // btnCloseAU
            // 
            this.btnCloseAU.Location = new System.Drawing.Point(253, 229);
            this.btnCloseAU.Name = "btnCloseAU";
            this.btnCloseAU.Size = new System.Drawing.Size(112, 34);
            this.btnCloseAU.TabIndex = 1;
            this.btnCloseAU.Text = "Close";
            this.btnCloseAU.UseVisualStyleBackColor = true;
            this.btnCloseAU.Click += new System.EventHandler(this.btnCloseAU_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 403);
            this.Controls.Add(this.btnCloseAU);
            this.Controls.Add(this.label1);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCloseAU;
    }
}