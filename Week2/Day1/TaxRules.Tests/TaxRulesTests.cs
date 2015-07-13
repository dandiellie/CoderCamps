using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxRules.Tests
{
    [TestClass]
    public class TaxRulesTests
    {
        [TestMethod]
        public void TestIsLessThanFive()
        {
            //Arrange
            Citizen billy = new Citizen("Bill", "McMurray", Convert.ToDateTime("01/05/2014"));
            Tax ErehwonTaxes = new Tax();

            //Act
            ErehwonTaxes.IsLessThanFive(billy.BirthDate);

            //Assert
            Assert.AreEqual(0, ErehwonTaxes.TaxRate);
        }

        [TestMethod]
        public void TestIsLastNameW()
        {
            //Arrange
            Citizen billy = new Citizen("Bill", "Walters", Convert.ToDateTime("01/05/1990"));
            Tax ErehwonTaxes = new Tax();

            //Act
            ErehwonTaxes.IsLastNameW(billy.LastName);

            //Assert
            Assert.AreEqual(1, ErehwonTaxes.TaxDiscount);
        }

        [TestMethod]
        public void TestIsFirstNameJ()
        {
            //Arrange
            Citizen jimmy = new Citizen("James", "McMurray", Convert.ToDateTime("01/05/1990"));
            Tax ErehwonTaxes = new Tax();

            //Act
            ErehwonTaxes.IsFirstNameJ(jimmy.FirstName);

            //Assert
            Assert.AreEqual(0.16m, ErehwonTaxes.TaxRate);
        }

        [TestMethod]
        public void TestIsThursday()
        {
            //Arrange
            Tax ErehwonTaxes = new Tax();

            //Act
            ErehwonTaxes.IsThursday();

            //Assert
            Assert.AreEqual(0.08m, ErehwonTaxes.TaxRate);
        }

        [TestMethod]
        public void TestIsTaxNonNegative()
        {
            //Arrange
            Citizen billy = new Citizen("Bill", "Walters", Convert.ToDateTime("01/05/1990"));
            Tax ErehwonTaxes = new Tax();
            decimal price = 1.00m;

            //Act
            ErehwonTaxes.IsLastNameW(billy.LastName);
            ErehwonTaxes.IsTaxNonNegative(price);

            //Assert
            Assert.AreEqual(0, ErehwonTaxes.TaxDiscount);
        }

        [TestMethod]
        public void TestCalculate1()
        {
            //Arrange
            Citizen billy = new Citizen("Bill", "McMurray", Convert.ToDateTime("01/05/1990"));
            Tax ErehwonTaxes = new Tax();
            decimal price = 100.00m;

            //Act
            decimal total = ErehwonTaxes.Calculate(billy, price);

            //Assert
            Assert.AreEqual(108.00m, total);
        }

        [TestMethod]
        public void TestCalculate2()
        {
            //Arrange
            Citizen jimmy = new Citizen("James", "Walters", Convert.ToDateTime("01/05/2014"));
            Tax ErehwonTaxes = new Tax();
            decimal price = 1.00m;

            //Act
            decimal total = ErehwonTaxes.Calculate(jimmy, price);

            //Assert
            Assert.AreEqual(1m, total);
        }
    }
}
