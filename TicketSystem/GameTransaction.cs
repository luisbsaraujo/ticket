using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    class GameTransaction
    {
        public string TransactionName { get; set; }
        public int NumOfRegularSeats { get; set; }
        public int NumOfPremiumSeats { get; set; }
        public double TotalPrice { get { return (NumOfPremiumSeats * 79.99) + (NumOfRegularSeats * 39.99); } }

        public GameTransaction()
        {
            TransactionName = "";
            NumOfRegularSeats = 0;
            NumOfPremiumSeats = 0;
        }

        public GameTransaction(string tName, int numReg, int numPre)
        {
            TransactionName = tName;
            NumOfRegularSeats = numReg;
            NumOfPremiumSeats = numPre;
        }

        public override string ToString()
        {
            char delim = ',';
            string outputStr = "";
            outputStr += TransactionName + delim
                + NumOfRegularSeats + delim
                + NumOfPremiumSeats + delim
                + TotalPrice.ToString("C");
            return outputStr;
        }

    }
}
