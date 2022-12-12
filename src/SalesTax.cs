using System.Text.RegularExpressions;
using SalesTax.Entities;

namespace SalesTax
{
    public partial class SalesTax : Form
    {
        Basket basket = new Basket { Items = new List<Item> { } };
        public SalesTax()
        {
            InitializeComponent();
        }

        #region Validations
        private void itemName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textItemName.Text))
            {
                e.Cancel = true;
                textItemName.Focus();
                itemError.SetError(textItemName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                itemError.SetError(textItemName, "");
            }
        }

        private void textPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex currencyFormat = new Regex(@"^([0-9]\d*)\.\d\d$");

            if (string.IsNullOrWhiteSpace(textPrice.Text) || !currencyFormat.IsMatch(textPrice.Text))
            {
                e.Cancel = true;
                textPrice.Focus();
                itemError.SetError(textPrice, "Please enter a valid format");
            }
            else
            {
                e.Cancel = false;
                itemError.SetError(textPrice, "");
            }
        }

        private void textQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textItemName.Text) || !Int32.TryParse(textQuantity.Text, out int result) || result <= 0)
            {
                e.Cancel = true;
                textQuantity.Focus();
                itemError.SetError(textQuantity, "Please enter a valid number");
            }
            else
            {
                e.Cancel = false;
                itemError.SetError(textQuantity, "");
            }
        }

        private void comboBoxCategory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((string?)comboBoxCategory.SelectedItem))
            {
                e.Cancel = true;
                textPrice.Focus();
                itemError.SetError(comboBoxCategory, "Please select a category");
            }
            else
            {
                e.Cancel = false;
                itemError.SetError(comboBoxCategory, "");
            }
        }
        #endregion

        #region SalesTax Functionality
        private void buttonAddToBasket_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Item basketItem = new Item();

                basketItem.Name = textItemName.Text.Trim();
                basketItem.Price = Decimal.Parse(textPrice.Text);
                basketItem.Quantity = Int32.Parse(textQuantity.Text);
                basketItem.Category = (string)comboBoxCategory.SelectedItem;
                if (radioButtonImportedYes.Checked)
                {
                    basketItem.Imported = true;
                }
                else
                {
                    basketItem.Imported = false;
                }
                calculateSalesTax(basketItem);
                addToBasket(basketItem);
                clearValues();
            }
        }

        private void buttonEmptyBasket_Click(object sender, EventArgs e)
        {
            dataGridViewBasket.Rows.Clear();
            basket.Items.Clear();
            basket.TotalSalesTax = 0;
            basket.TotalPrice = 0;
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.addToReceipt(basket);
            receipt.ShowDialog();
            dataGridViewBasket.Rows.Clear();
            basket.Items.Clear();
            basket.TotalSalesTax = 0;
            basket.TotalPrice = 0;
        }

        private void clearValues()
        {
            textItemName.Clear();
            textPrice.Clear();
            textQuantity.Clear();
            comboBoxCategory.SelectedIndex = -1;
            radioButtonImportedYes.Checked = true;
        }
        #endregion

        #region  Basket Logic
        public static void calculateSalesTax(Item item)
        {
            decimal taxRate = .1m;
            decimal impTaxRate = .05m;
            if (item.Imported == true)
            {
                if (item.Category == "Other")
                {
                    item.SalesTax = Math.Round((item.Price * (taxRate + impTaxRate)), 2);
                }
                else
                {
                    item.SalesTax = Math.Round((item.Price * impTaxRate), 2);
                }
            }
            else
            {
                if (item.Category == "Other")
                {
                    item.SalesTax = Math.Round((item.Price * taxRate), 2);
                }
            }

            item.SalesTax = Math.Ceiling(item.SalesTax / .05m) * .05m;
        }

        private void addToBasket(Item item)
        {
            dataGridViewBasket.Rows.Add(item.Name, item.Price, item.Quantity,item.Category,item.Imported);
            var checkForItem = basket.Items.FirstOrDefault(x => x.Name == item.Name && x.Price == item.Price && x.Category == item.Category && x.Imported == item.Imported);
            if (checkForItem != null)
            {
                checkForItem.Quantity++;

            }
            else
            {
                basket.Items.Add(item);
            }
        }
        #endregion

    }
}