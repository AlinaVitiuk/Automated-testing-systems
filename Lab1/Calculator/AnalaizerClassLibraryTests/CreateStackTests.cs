using System;
using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalaizerClassLibraryTests
{
    [TestClass]
    public class CreateStackTests
    {

        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;Database=TestData;Trusted_Connection=True;MultipleActiveResultSets=true", "TestingData", DataAccessMethod.Sequential)]
        [TestMethod]
        public void CreateStack_FromDataSourceTest()
        {
            // Arrange
            string initial = (string)TestContext.DataRow["actual"];
            string expected = (string)TestContext.DataRow["expected"];
            AnalaizerClass.expression = initial;

            // Actual
            string actual = string.Join("", AnalaizerClass.CreateStack().ToArray());

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
