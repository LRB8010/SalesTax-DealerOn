using SalesTax;
using SalesTax.Entities;

namespace SalesTaxTest
{
    [TestClass]
    public class SalesTaxTest
    {
        [TestMethod]
        public void NonImportedItemSalesTaxCalculation()
        {
            decimal expectedTax = 1.50m;

            Item item = new Item();
            item.Name = "Music CD";
            item.Price = 14.99m;
            item.Quantity = 1;
            item.Category = "Other";
            item.Imported = false;

            SalesTax.SalesTax.calculateSalesTax(item);

            Assert.AreEqual(expectedTax, item.SalesTax,"Sales Tax calculated wrong");
            
        }

        [TestMethod]
        public void ImportedItemSalesTaxCalculation()
        {
            decimal expectedTax = 2.25m;

            Item item = new Item();
            item.Name = "Music CD";
            item.Price = 14.99m;
            item.Quantity = 1;
            item.Category = "Other";
            item.Imported = true;

            SalesTax.SalesTax.calculateSalesTax(item);

            Assert.AreEqual(expectedTax, item.SalesTax, "Sales Tax calculated wrong");

        }

        [TestMethod]
        public void BasketTotalCalculation()
        {
            decimal expectedTotalPrice = 49.47m;

            Basket basket = new Basket { Items = new List<Item> { } };
            Item item = new Item();
            item.Name = "Music CD";
            item.Price = 14.99m;
            item.Quantity = 3;
            item.Category = "Other";
            item.Imported = false;
            SalesTax.SalesTax.calculateSalesTax(item);

            Receipt.calculateTotals(basket, item);

            Assert.AreEqual(expectedTotalPrice, basket.TotalPrice, "Total calculated wrong");

        }

        [TestMethod]
        public void ImportedBasketTotalCalculation()
        {
            decimal expectedTotalPrice = 51.72m;

            Basket basket = new Basket { Items = new List<Item> { } };
            Item item = new Item();
            item.Name = "Music CD";
            item.Price = 14.99m;
            item.Quantity = 3;
            item.Category = "Other";
            item.Imported = true;
            SalesTax.SalesTax.calculateSalesTax(item);

            Receipt.calculateTotals(basket, item);

            Assert.AreEqual(expectedTotalPrice, basket.TotalPrice, "Total calculated wrong");

        }
    }
}