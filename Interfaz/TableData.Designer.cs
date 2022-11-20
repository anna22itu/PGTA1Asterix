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


        private Button iconBtnDTClose;
        private Button iconBtnDTMin;
        private Button iconBtnDTMax;

        private void InitializeComponent()
        {
            this.iconBtnDTMin = new FontAwesome.Sharp.IconButton();
            this.iconBtnDTMax = new FontAwesome.Sharp.IconButton();
            this.iconBtnDTClose = new FontAwesome.Sharp.IconButton();

            ((System.ComponentModel.ISupportInitialize)(this.iconBtnDTMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnDTMax)).EndInit();
            this.SuspendLayout();


        }
    }
}