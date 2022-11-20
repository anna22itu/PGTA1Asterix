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
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(400, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "OPEN FILE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "EXPORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelUp
            // 
            this.panelUp.Location = new System.Drawing.Point(533, 132);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(300, 150);
            this.panelUp.TabIndex = 5;
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMENU.Location = new System.Drawing.Point(0, 0);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(267, 750);
            this.panelMENU.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(476, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 150);
            this.panel3.TabIndex = 7;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMENU);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Panel panelUp;
        private Panel panelMENU;
        private Panel panel3;
    }
}