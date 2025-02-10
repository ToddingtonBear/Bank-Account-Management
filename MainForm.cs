using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_Management
{
    public partial class MainForm : Form
    {
        private User _user;
        private List<Account> _accounts;
        private List<LoanDetail> _loanDetails;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            using (StreamReader r = new StreamReader("C:\\Users\\Chris\\source\\repos\\Bank Account Management\\accounts.json"))
            {
                string json = r.ReadToEnd();
                _accounts = JObject.Parse(json)["accounts"].ToObject<List<Account>>();
                _loanDetails = JObject.Parse(json)["loanDetails"].ToObject<List<LoanDetail>>();
                _accounts.RemoveAll(a => a.UserId != _user.Id);
                List<int> accountIds = _accounts.Select(a => a.Id).ToList();
                _loanDetails.RemoveAll(ld => !accountIds.Contains(ld.AccountId));
            }

            foreach(Account account in _accounts)
            {
                string[] subItems = { account.Balance.ToString(), account.Created.Date.ToString() };
                accountsListView.Items.Add(account.Type.ToString()).SubItems.AddRange(subItems);
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            var transferForm = new TransferForm(_accounts);
            transferForm.Show();
        }

        private void requestLoanButton_Click(object sender, EventArgs e)
        {
            if (_user.CreditRating >= InterestCalculator.CreditRatingThreshold)
            {
                // SHOW FORM TO INPUT DURATION
                // WHEN DURATION AND AMOUNT IS INPUT AND SUBMIT, CALL IS MADE TO "InterestCalculator" TO CALCULATE INTEREST RATE
                // NEW LOAN ACCOUNT WILL THEN BE MADE AND AMOUNT LOANED WILL APPEAR AS NEGATIVE VALUE IN THAT ACCOUNT. 
                // AMOUNT LOANED WILL BE ADDED TO USER CURRENT ACCOUNT
            }
            else
            {
                // SHOW DIALOG INFORMING USER THAT THEY DON'T QUALIFY AS THEIR CREDIT RATING IS TOO LOW
            }
        }
    }
}
