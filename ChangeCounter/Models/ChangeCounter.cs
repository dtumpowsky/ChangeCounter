using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace CoinApp.Models
{
    public class Change
    {
        // private string _userInput;
        private decimal _quarters;
        // private decimal _dimes;
        // private decimal _nickels;
        // private decimal _pennies;
        // private string _changeOutput;
        private static List<Change> _instances = new List<Change> {};

        public Change(decimal quarters)
        {
            // _userInput = userInput;
            _quarters = quarters;
            // _dimes = dimes;
            // _nickels = nickels;
            // _pennies = pennies;
            // _changeOutput = changeOutput;
            // _instances.Add(this);
        }

        // public string GetUserInput()
        // {
        //     return _userInput;
        // }

        // public void SetUserInput(newUserInput)
        // {
        //     _userInput = newUserInput;
        // }

        public decimal CalculateChange(decimal price)
        {
            _quarters = 0.25m;
            price %= _quarters;
            return price;
            // _dimes = price / 0.10m;
            // _nickels = price / 0.05m;
            // _pennies = price / 0.01m;

        }

    }
}
