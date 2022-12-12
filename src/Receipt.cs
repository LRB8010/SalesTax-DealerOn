using SalesTax.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTax
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        public void addToReceipt(Basket basket)
        {
            var itemsInBasket = basket.Items;

            foreach (var item in itemsInBasket)
            {
                calculateTotals(basket, item);
                if (item.Quantity > 1)
                {
                    receiptGridView.Rows.Add($"{item.Name}: {(item.Price + item.SalesTax) * item.Quantity} ({item.Quantity} @ {item.Price + item.SalesTax})");
                }
                else
                {
                    receiptGridView.Rows.Add($"{item.Name}: {item.Price + item.SalesTax}");
                }
            }
            receiptGridView.Rows.Add($"Sales Taxes: {basket.TotalSalesTax}");
            receiptGridView.Rows.Add($"Total: {basket.TotalPrice}");
        }

        public static void calculateTotals(Basket basket, Item item)
        {
            basket.TotalSalesTax += item.SalesTax * item.Quantity;
            basket.TotalPrice += (item.Price + item.SalesTax) * item.Quantity;
        }
    }
}
