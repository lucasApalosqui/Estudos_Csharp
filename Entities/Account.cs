﻿using System;
using System.Globalization;
using ExceptionPersonalizadaAccount.Entities.Exceptions;

namespace ExceptionPersonalizadaAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public override string ToString()
        {
            return "New balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposit(double amont)
        {

            Balance += amont;
        }

        public void Withdraw(double amont)
        {
            if(amont > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            if(amont > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            Balance -= amont;
        }
    }
}
