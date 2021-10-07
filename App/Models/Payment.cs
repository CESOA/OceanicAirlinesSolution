using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; private set; }
        public string CardholdersName { get; set; }
        public string CardNo { get; set; }
        public string ExpirationDate { get; set; }
        public string Cvv { get; set; }
    }
}