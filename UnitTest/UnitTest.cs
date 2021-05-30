using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit;
using Unit.Controllers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\Trbry\\Documents\\Unit\\UnitTest\\UnitTest.csv", "UnitTest#csv",
            DataAccessMethod.Sequential), DeploymentItem("UnitTest.csv"), TestMethod]
        public void Unit()
        {
            if (TestContext.DataRow["CAIXA"].ToString() == "OPEN")
                OperationController.OpenCashier();
            else
                OperationController.CloseCashier();

            OperationController.ChangeCash(double.Parse(TestContext.DataRow["SALDO"].ToString()));

            if (TestContext.DataRow["TIPO"].ToString() == "LOSS")
                OperationController.DoLoss(double.Parse(TestContext.DataRow["VALOR"].ToString()), TestContext.DataRow["MOTIVO"].ToString());
            else
                OperationController.DoProfit(double.Parse(TestContext.DataRow["VALOR"].ToString()), TestContext.DataRow["MOTIVO"].ToString());

            Assert.AreEqual(double.Parse(TestContext.DataRow["SAIDA"].ToString()), OperationController.GetCash());
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\Trbry\\Documents\\Unit\\UnitTest\\IntegrationTest.csv", "IntegrationTest#csv",
            DataAccessMethod.Sequential), DeploymentItem("IntegrationTest.csv"), TestMethod]
        public void Integration()
        {
            UnitFrame frame = new UnitFrame();
            if (TestContext.DataRow["CAIXA"].ToString() == "OPEN")
                frame.SalesButton.Text = "OFF";
            else
                frame.SalesButton.Text = "ON";
            frame.SalesButton_Click(null, null);

            OperationController.ChangeCash(double.Parse(TestContext.DataRow["SALDO"].ToString()));

            if (TestContext.DataRow["TIPO"].ToString() == "LOSS")
                frame.LossButton_Click(null, null);
            else
                frame.ProfitButton_Click(null, null);

            frame.ValueText.Text = TestContext.DataRow["VALOR"].ToString();
            frame.DescriptionText.Text = TestContext.DataRow["MOTIVO"].ToString();

            frame.ConfirmButton_Click(null, null);

            Assert.AreEqual(double.Parse(TestContext.DataRow["SAIDA"].ToString()), OperationController.GetCash());
        }
    }
}
