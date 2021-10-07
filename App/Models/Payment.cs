using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Payment
    {
        public Payment(string cardholdersName, string cardNo, string expirationDate, string cvv)
        {
            CardholdersName = cardholdersName;
            CardNo = cardNo;
            ExpirationDate = expirationDate;
            Cvv = cvv;
        }

        private string CardholdersName { get; set; }
        private string CardNo { get; set; }
        private string ExpirationDate { get; set; }
        private string Cvv { get; set; }
    }
}