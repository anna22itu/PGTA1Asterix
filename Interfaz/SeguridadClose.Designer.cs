namespace Asterix_Decoder
{
    partial class SeguridadClose
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
            this.labelSeguridad = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeguridad
            // 
            this.labelSeguridad.AutoSize = true;
            this.labelSeguridad.Location = new System.Drawing.Point(82, 91);
            this.labelSeguridad.Name = "labelSeguridad";
            this.labelSeguridad.Size = new System.Drawing.Size(361, 25);
            this.labelSeguridad.TabIndex = 0;
            this.labelSeguridad.Text = "Are you sure you want to exit the simulator?";
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSi.Location = new System.Drawing.Point(108, 174);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(112, 34);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNo.Location = new System.Drawing.Point(226, 174);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(112, 34);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // SeguridadClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(497, 274);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.labelSeguridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeguridadClose";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSeguridad;
        private Button btnSi;
        private Button btnNo;
    }
}