﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class SavingAccount : Account
    {
        public SavingAccount()
        {
            AccountType = "Saving";
        }
    }
}
