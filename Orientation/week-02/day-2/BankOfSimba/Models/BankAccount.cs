using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance{ get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }

        public bool IsGood { get; set; }

        public BankAccount(string name, decimal balance, string animalType, bool isKing = true, bool isGood = true)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsGood = isGood;
        }

        public BankAccount() { }
    }
}
