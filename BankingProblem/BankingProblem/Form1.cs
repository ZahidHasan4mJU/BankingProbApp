using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingProblem
{
    public partial class BankingProblemForm : Form
    {
        public BankingProblemForm()
        {
            InitializeComponent();
        }
        Account anAccount = new Account();
        private double amount;
        private string a;

        
        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.accNum = accountNumberTextBox.Text;
            anAccount.custName = customerNameTextBox.Text;
            

            accountNumberTextBox.Text = "";
            customerNameTextBox.Text = "";

            reportButton.Enabled = false;
            createButton.Enabled = false;


        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                if (amountTextBox.Text != "")
                {
                    amount = Convert.ToDouble(amountTextBox.Text);
                    anAccount.Deposit(amount);

                }
                else
                {
                    MessageBox.Show(@"not deposited... ");
                }
                createButton.Enabled = false;
                withdrawButton.Enabled = true;
                reportButton.Enabled = true;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + anAccount.custName+"\nAccount no. "+anAccount.accNum+"\nBalance: "+anAccount.balance.ToString());
            createButton.Enabled = true;
        }
        

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                if (amountTextBox.Text != "")
                {
                    amount = Convert.ToDouble(amountTextBox.Text);
                    anAccount.Withdraw(amount);
                }
                else
                {
                    MessageBox.Show(@"not withdrawed ...");
                }
                createButton.Enabled = false;
                depositButton.Enabled = true;
                reportButton.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
