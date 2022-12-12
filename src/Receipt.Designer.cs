namespace SalesTax
{
    partial class Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receiptGridView = new System.Windows.Forms.DataGridView();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receiptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptGridView
            // 
            this.receiptGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.receiptGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.receiptGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.receiptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receiptGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.receiptGridView.EnableHeadersVisualStyles = false;
            this.receiptGridView.Location = new System.Drawing.Point(11, 12);
            this.receiptGridView.Name = "receiptGridView";
            this.receiptGridView.RowHeadersVisible = false;
            this.receiptGridView.RowTemplate.Height = 25;
            this.receiptGridView.Size = new System.Drawing.Size(365, 284);
            this.receiptGridView.TabIndex = 0;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.Width = 400;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 343);
            this.Controls.Add(this.receiptGridView);
            this.Name = "Receipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.receiptGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView receiptGridView;
        private DataGridViewTextBoxColumn descriptionColumn;
    }
}