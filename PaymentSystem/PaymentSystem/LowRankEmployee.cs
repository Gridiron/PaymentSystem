using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    class LowRankEmployee
    {
        string FIO;
        int goodsSold;
        double hoursWorked;
        int LastVAC;
        string Login;
        string Password;
        double toPay;
        public LowRankEmployee(string FIO, int goodsSold, double hoursWorked, int LastVAC, int toPay)
        {
            this.FIO = FIO;
            this.goodsSold = goodsSold;
            this.hoursWorked = hoursWorked;
            this.LastVAC = LastVAC;
            this.toPay = toPay;
        }
    }
}
