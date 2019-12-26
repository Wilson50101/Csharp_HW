namespace NCKU_Eat
{
    partial class AllRestaurant
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
            this.DGV_AllRestaurant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_AllRestaurant
            // 
            this.DGV_AllRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AllRestaurant.Location = new System.Drawing.Point(12, 12);
            this.DGV_AllRestaurant.Name = "DGV_AllRestaurant";
            this.DGV_AllRestaurant.RowTemplate.Height = 24;
            this.DGV_AllRestaurant.Size = new System.Drawing.Size(736, 426);
            this.DGV_AllRestaurant.TabIndex = 0;
            // 
            // AllRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.DGV_AllRestaurant);
            this.Name = "AllRestaurant";
            this.Text = "AllRestaurant";
            this.Load += new System.EventHandler(this.AllRestaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AllRestaurant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_AllRestaurant;
    }
}