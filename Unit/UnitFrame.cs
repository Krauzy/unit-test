using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unit.Controllers;

namespace Unit
{
    public partial class UnitFrame : Form
    {
        public bool sales = false;
        public bool operation = false;

        public bool error = false;

        public UnitFrame()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
            VersionText.Text = info.ProductVersion;
            VersionText.Text = VersionText.Text.Remove(VersionText.Text.Length - 2);
            CashText.Text = "R$ " + OperationController.GetCash().ToString();
            // notifyIcon.ShowBalloonTip(2000, "Bem Vindo", "Ola", ToolTipIcon.Info);
        }

        public void SalesButton_Click(object sender, EventArgs e)
        {
            if (SalesButton.Text == "ON")
            {
                SalesButton.Text = "OFF";
                SalesButton.BackColor = Color.DarkRed;
                sales = false;
            }
            else
            {
                SalesButton.Text = "ON";
                SalesButton.BackColor = Color.DarkGreen;
                sales = true;
            }
            this.ActiveControl = null;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LossButton_Click(object sender, EventArgs e)
        {
            operation = false;

            LossButton.BackColor = Color.DarkRed;
            LossButton.ForeColor = Color.White;
            LossButton.Font = new Font(LossButton.Font, FontStyle.Bold);

            ProfitButton.BackColor = Color.White;
            ProfitButton.ForeColor = Color.DarkGreen;
            ProfitButton.Font = new Font(LossButton.Font, FontStyle.Regular);
            this.ActiveControl = null;
        }

        public void ProfitButton_Click(object sender, EventArgs e)
        {
            operation = true;

            LossButton.BackColor = Color.White;
            LossButton.ForeColor = Color.DarkRed;
            LossButton.Font = new Font(LossButton.Font, FontStyle.Regular);

            ProfitButton.BackColor = Color.DarkGreen;
            ProfitButton.ForeColor = Color.White;
            ProfitButton.Font = new Font(LossButton.Font, FontStyle.Bold);
            this.ActiveControl = null;
        }

        private void ValueText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(ValueText.Text);
                CheckText.Text = "✔️ Valor Válido";
                CheckText.ForeColor = Color.FromArgb(0, 192, 0);
            }
            catch
            {
                CheckText.Text = "✕ Valor Inválido";
                CheckText.ForeColor = Color.Red;
            }
            
        }

        private void ValueText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;

            if ((char.IsDigit(e.KeyChar)) && (sender as TextBox).Text.IndexOf(',') > -1 && (sender as TextBox).Text.IndexOf(',') < (sender as TextBox).Text.Length - 2)
                e.Handled = true;
        }

        public void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(sales == false)
            {
                error = false;
                Console.WriteLine(error);
                return;
            }
            else
            {
                if (ValueText.Text != string.Empty && double.Parse(ValueText.Text) != 0 && DescriptionText.Text != string.Empty)
                {
                    if (operation)
                    {
                        error = OperationController.DoProfit(double.Parse(ValueText.Text), DescriptionText.Text);
                        CashText.Text = "R$ " + OperationController.GetCash().ToString();
                        Console.WriteLine(error);
                    }                        
                    else
                    {
                        error = OperationController.DoLoss(double.Parse(ValueText.Text), DescriptionText.Text);
                        CashText.Text = "R$ " + OperationController.GetCash().ToString();
                        Console.WriteLine(error);
                    }
                }
                else
                {
                    error = false;
                    Console.WriteLine(error);
                    return;
                }   
            }
        }
    }
}
