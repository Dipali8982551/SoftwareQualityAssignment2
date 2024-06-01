using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareQualityAssignment2;

namespace Products.nunitTests
{
    public class ProductTests
    {
        // Tests for ProductID
        [Test]
        public void ProductID_SetAndGetProductID_ReturnsCorrectValue()
        {
            var product = new Product(1, "Test Product", 100m, 10);
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_SetMinProductID_ReturnsMinValue()
        {
            var product = new Product(1, "Test Product", 100m, 10);
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_SetMaxProductID_ReturnsMaxValue()
        {
            var product = new Product(5000, "Test Product", 100m, 10);
            Assert.That(product.ProductID, Is.EqualTo(5000));
        }

        // Tests for ProductName
        [Test]
        public void ProductName_SetAndGetProductName_ReturnsCorrectValue()
        {
            var product = new Product(1, "Test Product", 100m, 10);
            Assert.That(product.ProductName, Is.EqualTo("Test Product"));
        }

        [Test]
        public void ProductName_SetEmptyProductName_ReturnsEmptyString()
        {
            var product = new Product(1, "", 100m, 10);
            Assert.That(product.ProductName, Is.EqualTo(""));
        }

        [Test]
        public void ProductName_SetNullProductName_ReturnsNull()
        {
            var product = new Product(1, null, 100m, 10);
            Assert.That(product.ProductName, Is.Null);
        }

        // Tests for Price
        [Test]
        public void Price_SetAndGetPrice_ReturnsCorrectValue()
        {
            var product = new Product(1, "Test Product", 100m, 10);
            Assert.That(product.Price, Is.EqualTo(100m));
        }

        [Test]
        public void Price_SetMinPrice_ReturnsMinValue()
        {
            var product = new Product(1, "Test Product", 1m, 10);
            Assert.That(product.Price, Is.EqualTo(1m));
        }

        [Test]
        public void Price_SetMaxPrice_ReturnsMaxValue()
        {
            var product = new Product(1, "Test Product", 10000m, 10);
            Assert.That(product.Price, Is.EqualTo(10000m));
        }

        // Tests for Stock
        [Test]
        public void Stock_SetAndGetStock_ReturnsCorrectValue()
        {
            var product = new Product(1, "Test Product", 100m, 10);
            Assert.That(product.Stock, Is.EqualTo(10));
        }

        [Test]
        public void Stock_SetMinStock_ReturnsMinValue()
        {
            var product = new Product(1, "Test Product", 100, 1);
            Assert.That(product.Stock, Is.EqualTo(1));
        }

        [Test]
        public void Stock_SetMaxStock_ReturnsMaxValue()
        {
            var product = new Product(1, "Test Product", 100, 5000);
            Assert.That(product.Stock, Is.EqualTo(5000));
        }

        // Tests for IncreaseStock
        [Test]
        public void IncreaseStock_PositiveAmount_IncreasesStock()
        {
            var product = new Product(1, "Test Product", 100, 10);
            product.IncreaseStock(5);
            Assert.That(product.Stock, Is.EqualTo(15));
        }

        [Test]
        public void IncreaseStock_ZeroAmount_StockUnchanged()
        {
            var product = new Product(1, "Test Product", 100, 10);
            product.IncreaseStock(0);
            Assert.That(product.Stock, Is.EqualTo(10));
        }

        [Test]
        public void IncreaseStock_AmountLessThanCurrentStock_StockIncreasedCorrectly()
        {
            var product = new Product(1, "Test Product", 100, 10); // Initial stock is 10
            product.IncreaseStock(0); // Decrease stock by 5
            Assert.That(product.Stock, Is.EqualTo(10)); // Verify that stock is decreased to 5
        }

        // Tests for DecreaseStock
        [Test]
        public void DecreaseStock_PositiveAmount_DecreasesStock()
        {
            var product = new Product(1, "Test Product", 100, 10);
            product.DecreaseStock(5);
            Assert.That(product.Stock, Is.EqualTo(5));
        }

        [Test]
        public void DecreaseStock_ZeroAmount_StockUnchanged()
        {
            var product = new Product(1, "Test Product", 100, 10);
            product.DecreaseStock(0);
            Assert.That(product.Stock, Is.EqualTo(10));
        }

        [Test]
        public void DecreaseStock_AmountLessThanCurrentStock_StockDecreasedCorrectly()
        {
            var product = new Product(1, "Test Product", 100, 10); // Initial stock is 10
            product.DecreaseStock(5); // Decrease stock by 5
            Assert.That(product.Stock, Is.EqualTo(5)); // Verify that stock is decreased to 5
        }
    }
}
