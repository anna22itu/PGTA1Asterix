namespace AsterixDecoder
{
    partial class KML
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
            this.labelInfoKMLGenerated = new System.Windows.Forms.Label();
            this.iconPictureBoxKMLfile = new FontAwesome.Sharp.IconPictureBox();
            this.buttonKMLYes = new System.Windows.Forms.Button();
            this.buttonKMLNo = new System.Windows.Forms.Button();
            this.labelIngoGoogleEarth = new System.Windows.Forms.Label();
            this.labelKMLOpenedGE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxKMLfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoKMLGenerated
            // 
            this.labelInfoKMLGenerated.AutoSize = true;
            this.labelInfoKMLGenerated.Location = new System.Drawing.Point(219, 56);
            this.labelInfoKMLGenerated.Name = "labelInfoKMLGenerated";
            this.labelInfoKMLGenerated.Size = new System.Drawing.Size(145, 25);
            this.labelInfoKMLGenerated.TabIndex = 0;
            this.labelInfoKMLGenerated.Text = "KML generated :)";
            // 
            // iconPictureBoxKMLfile
            // 
            this.iconPictureBoxKMLfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconPictureBoxKMLfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxKMLfile.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.iconPictureBoxKMLfile.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxKMLfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxKMLfile.IconSize = 85;
            this.iconPictureBoxKMLfile.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBoxKMLfile.Name = "iconPictureBoxKMLfile";
            this.iconPictureBoxKMLfile.Size = new System.Drawing.Size(86, 85);
            this.iconPictureBoxKMLfile.TabIndex = 1;
            this.iconPictureBoxKMLfile.TabStop = false;
            // 
            // buttonKMLYes
            // 
            this.buttonKMLYes.Location = new System.Drawing.Point(171, 198);
            this.buttonKMLYes.Name = "buttonKMLYes";
            this.buttonKMLYes.Size = new System.Drawing.Size(112, 34);
            this.buttonKMLYes.TabIndex = 2;
            this.buttonKMLYes.Text = "YES";
            this.buttonKMLYes.UseVisualStyleBackColor = true;
            this.buttonKMLYes.Click += new System.EventHandler(this.buttonKMLYes_Click);
            this.buttonKMLYes.MouseEnter += new System.EventHandler(this.buttonKMLYes_MouseEnter);
            this.buttonKMLYes.MouseLeave += new System.EventHandler(this.buttonKMLYes_MouseLeave);
            // 
            // buttonKMLNo
            // 
            this.buttonKMLNo.Location = new System.Drawing.Point(289, 198);
            this.buttonKMLNo.Name = "buttonKMLNo";
            this.buttonKMLNo.Size = new System.Drawing.Size(112, 34);
            this.buttonKMLNo.TabIndex = 3;
            this.buttonKMLNo.Text = "NO";
            this.buttonKMLNo.UseVisualStyleBackColor = true;
            this.buttonKMLNo.Click += new System.EventHandler(this.buttonKMLNo_Click);
            // 
            // labelIngoGoogleEarth
            // 
            this.labelIngoGoogleEarth.AutoSize = true;
            this.labelIngoGoogleEarth.Location = new System.Drawing.Point(50, 241);
            this.labelIngoGoogleEarth.Name = "labelIngoGoogleEarth";
            this.labelIngoGoogleEarth.Size = new System.Drawing.Size(463, 25);
            this.labelIngoGoogleEarth.TabIndex = 5;
            this.labelIngoGoogleEarth.Text = "You must have downloaded the Google Earth application";
            // 
            // labelKMLOpenedGE
            // 
            this.labelKMLOpenedGE.AutoSize = true;
            this.labelKMLOpenedGE.Location = new System.Drawing.Point(122, 133);
            this.labelKMLOpenedGE.Name = "labelKMLOpenedGE";
            this.labelKMLOpenedGE.Size = new System.Drawing.Size(331, 25);
            this.labelKMLOpenedGE.TabIndex = 6;
            this.labelKMLOpenedGE.Text = "Do you want to open it in google earth?";
            // 
            // KML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 303);
            this.Controls.Add(this.labelKMLOpenedGE);
            this.Controls.Add(this.labelIngoGoogleEarth);
            this.Controls.Add(this.buttonKMLNo);
            this.Controls.Add(this.buttonKMLYes);
            this.Controls.Add(this.iconPictureBoxKMLfile);
            this.Controls.Add(this.labelInfoKMLGenerated);
            this.Name = "KML";
            this.Text = "KML";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxKMLfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfoKMLGenerated;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxKMLfile;
        private Button buttonKMLYes;
        private Button buttonKMLNo;
        private Label labelIngoGoogleEarth;
        private Label labelKMLOpenedGE;
    }
}