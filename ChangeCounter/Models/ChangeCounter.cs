using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace CoinApp.Models
{
    public class Change
    {
        // private string _userInput;
        private decimal _quarters;
        private decimal _dimes;
        // private decimal _nickels;
        // private decimal _pennies;
        // private string _changeOutput;
        private static List<Change> _instances = new List<Change> {};

        public Change(decimal quarters = 0.0m, decimal dimes = 0.0m, decimal nickels = 0.0m, decimal pennies = 0.0m)
        {
            // _userInput = userInput;
            _quarters = quarters;
            _dimes = dimes;
            // _nickels = nickels;
            // _pennies = pennies;
            // _changeOutput = changeOutput;
            // _instances.Add(this);
        }

        public decimal ChangeAfterQuarters(decimal price)
        {
            _quarters = 0.25m;
            price %= _quarters;
            return price;

        }

        public decimal ChangeAfterDimes(decimal price)
        {
            _dimes = 0.10m;
            price %= _dimes;
            return price;
        }

        public decimal ChangeAfterNickels(decimal price)
        {
            _nickels = 0.10m;
            price %= _nickels;
            return price;
        }

        public decimal ChangeAfterPennies(decimal price)
        {
            _pennies = 0.10m;
            price %= _pennies;
            return price;
        }
    }
}
