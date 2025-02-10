using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Bank_Account_Management
{
    public partial class LoginForm : Form
    {
        private List<User> _users = new List<User>();
        public User LoggedInUser { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            using (StreamReader r = new StreamReader("C:\\Users\\Chris\\source\\repos\\Bank Account Management\\users.json"))
            {
                string json = r.ReadToEnd();
                _users = JObject.Parse(json)["users"].ToObject<List<User>>();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoggedInUser = _users.Where(u => u.Name.Trim().ToLower() == loginName.Text.Trim().ToLower()).FirstOrDefault();
            if (LoggedInUser != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
