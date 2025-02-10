using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_Management
{
    public partial class TransferForm : Form
    {
        private List<Account> _accounts;
        public TransferForm(List<Account> accounts)
        {
            InitializeComponent();
            _accounts = accounts;
            foreach (Account account in _accounts)
            {
                if (account.Balance < 1) continue;
                string[] subItems = { account.Type.ToString(), account.Balance.ToString(), account.Created.Date.ToString() };
                fromListView.Items.Add(account.Id.ToString()).SubItems.AddRange(subItems);
            }
        }

        private void fromListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            toListView.Items.Clear();
            foreach (Account account in _accounts)
            {
                if (account.Id.ToString() == fromListView.SelectedItems[0].Text) continue;
                string[] subItems = { account.Balance.ToString(), account.Created.Date.ToString() };
                toListView.Items.Add(account.Type.ToString()).SubItems.AddRange(subItems);
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // IF AMOUNT INPUT IS GREATER THAN BALANCE OF SELECTED ACCOUNT, INFORM USER

            // ELSE, SUBTRACT AMOUNT FROM SPECIFIED "FROM" ACCOUNT AND ADD AMOUNT TO SPECIFIED "TO" ACCOUNT
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
