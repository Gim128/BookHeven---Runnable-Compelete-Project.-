namespace BookHeven.Forms.OrderManagement
{
    partial class AllOrders
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
            this.grid_Order = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Order
            // 
            this.grid_Order.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Order.Location = new System.Drawing.Point(24, 95);
            this.grid_Order.Name = "grid_Order";
            this.grid_Order.RowHeadersWidth = 51;
            this.grid_Order.RowTemplate.Height = 24;
            this.grid_Order.Size = new System.Drawing.Size(944, 537);
            this.grid_Order.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(389, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(13, 18, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "All orders list";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 670);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grid_Order);
            this.Name = "AllOrders";
            this.Text = "AllOrders";
            this.Load += new System.EventHandler(this.AllOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Order;
        private System.Windows.Forms.Label label9;
    }
}