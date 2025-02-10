using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management
{
    public class Account
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountType
        {
            Current,
            Savings,
            Loan
        }

        public int Id { get; set; }
        //public string Name { get; set; }
        public int UserId { get; set; }
        public AccountType Type { get; set; }
        public float Balance { get; set; }
        public DateTime Created { get; set; }
    }

    public class LoanDetail
    {
        public int AccountId { get; set; }
        public int Duration { get; }
        public float Amount { get; }
        public float InterestRate { get; }
    }

}
