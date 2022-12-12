
using System.Windows.Forms;

namespace SalesTax
{
    partial class SalesTax
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textItemName = new System.Windows.Forms.TextBox();
            this.itemError = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelImported = new System.Windows.Forms.Label();
            this.radioButtonImportedYes = new System.Windows.Forms.RadioButton();
            this.radioButtonImportedNo = new System.Windows.Forms.RadioButton();
            this.buttonAddToBasket = new System.Windows.Forms.Button();
            this.buttonEmptyBasket = new System.Windows.Forms.Button();
            this.dataGridViewBasket = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(51, 9);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(66, 15);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Item Name";
            // 
            // textItemName
            // 
            this.textItemName.Location = new System.Drawing.Point(51, 38);
            this.textItemName.Name = "textItemName";
            this.textItemName.Size = new System.Drawing.Size(100, 23);
            this.textItemName.TabIndex = 1;
            this.textItemName.Validating += new System.ComponentModel.CancelEventHandler(this.itemName_Validating);
            // 
            // itemError
            // 
            this.itemError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.itemError.ContainerControl = this;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(51, 80);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(51, 108);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 23);
            this.textPrice.TabIndex = 3;
            this.textPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textPrice_Validating);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(52, 198);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 15);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Books",
            "Food",
            "Medical",
            "Other"});
            this.comboBoxCategory.Location = new System.Drawing.Point(52, 216);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCategory_Validating);
            // 
            // labelImported
            // 
            this.labelImported.AutoSize = true;
            this.labelImported.Location = new System.Drawing.Point(52, 254);
            this.labelImported.Name = "labelImported";
            this.labelImported.Size = new System.Drawing.Size(56, 15);
            this.labelImported.TabIndex = 6;
            this.labelImported.Text = "Imported";
            // 
            // radioButtonImportedYes
            // 
            this.radioButtonImportedYes.AutoSize = true;
            this.radioButtonImportedYes.Checked = true;
            this.radioButtonImportedYes.Location = new System.Drawing.Point(52, 281);
            this.radioButtonImportedYes.Name = "radioButtonImportedYes";
            this.radioButtonImportedYes.Size = new System.Drawing.Size(42, 19);
            this.radioButtonImportedYes.TabIndex = 7;
            this.radioButtonImportedYes.TabStop = true;
            this.radioButtonImportedYes.Text = "Yes";
            this.radioButtonImportedYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonImportedNo
            // 
            this.radioButtonImportedNo.AutoSize = true;
            this.radioButtonImportedNo.Location = new System.Drawing.Point(99, 281);
            this.radioButtonImportedNo.Name = "radioButtonImportedNo";
            this.radioButtonImportedNo.Size = new System.Drawing.Size(41, 19);
            this.radioButtonImportedNo.TabIndex = 8;
            this.radioButtonImportedNo.Text = "No";
            this.radioButtonImportedNo.UseVisualStyleBackColor = true;
            // 
            // buttonAddToBasket
            // 
            this.buttonAddToBasket.Location = new System.Drawing.Point(51, 306);
            this.buttonAddToBasket.Name = "buttonAddToBasket";
            this.buttonAddToBasket.Size = new System.Drawing.Size(89, 23);
            this.buttonAddToBasket.TabIndex = 9;
            this.buttonAddToBasket.Text = "Add To Basket";
            this.buttonAddToBasket.UseVisualStyleBackColor = true;
            this.buttonAddToBasket.Click += new System.EventHandler(this.buttonAddToBasket_Click);
            // 
            // buttonEmptyBasket
            // 
            this.buttonEmptyBasket.Location = new System.Drawing.Point(146, 306);
            this.buttonEmptyBasket.Name = "buttonEmptyBasket";
            this.buttonEmptyBasket.Size = new System.Drawing.Size(88, 23);
            this.buttonEmptyBasket.TabIndex = 10;
            this.buttonEmptyBasket.Text = "Empty Basket";
            this.buttonEmptyBasket.UseVisualStyleBackColor = true;
            this.buttonEmptyBasket.Click += new System.EventHandler(this.buttonEmptyBasket_Click);
            // 
            // dataGridViewBasket
            // 
            this.dataGridViewBasket.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBasket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBasket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.price,
            this.quantity,
            this.category,
            this.imported});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBasket.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBasket.EnableHeadersVisualStyles = false;
            this.dataGridViewBasket.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBasket.Location = new System.Drawing.Point(51, 335);
            this.dataGridViewBasket.Name = "dataGridViewBasket";
            this.dataGridViewBasket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewBasket.RowHeadersVisible = false;
            this.dataGridViewBasket.RowTemplate.Height = 25;
            this.dataGridViewBasket.Size = new System.Drawing.Size(460, 150);
            this.dataGridViewBasket.TabIndex = 9;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // imported
            // 
            this.imported.HeaderText = "Imported";
            this.imported.Name = "imported";
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(51, 491);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonTotal.TabIndex = 11;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(177, 116);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(93, 15);
            this.labelFormat.TabIndex = 12;
            this.labelFormat.Text = "Format Ex: 22.22";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(51, 144);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 15);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Quantity";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(51, 162);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 23);
            this.textQuantity.TabIndex = 14;
            this.textQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.textQuantity_Validating);
            // 
            // SalesTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 621);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.dataGridViewBasket);
            this.Controls.Add(this.buttonEmptyBasket);
            this.Controls.Add(this.buttonAddToBasket);
            this.Controls.Add(this.radioButtonImportedNo);
            this.Controls.Add(this.radioButtonImportedYes);
            this.Controls.Add(this.labelImported);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textItemName);
            this.Controls.Add(this.labelItemName);
            this.Name = "SalesTax";
            this.Text = "SalesTax";
            ((System.ComponentModel.ISupportInitialize)(this.itemError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelItemName;
        private TextBox textItemName;
        private ErrorProvider itemError;
        private TextBox textPrice;
        private Label labelPrice;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private RadioButton radioButtonImportedNo;
        private RadioButton radioButtonImportedYes;
        private Label labelImported;
        private Button buttonEmptyBasket;
        private Button buttonAddToBasket;
        private DataGridView dataGridViewBasket;
        private Button buttonTotal;
        private Label labelFormat;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn imported;
        private TextBox textQuantity;
        private Label labelQuantity;
    }
}