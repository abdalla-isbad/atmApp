using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmApp
{
     internal class TransactionLog
    {
        public TransactionLog(string TheDate, string typeOfTrans,int firstOp,int bAfter) 
        {
            string date = TheDate;
            string inOrOut = typeOfTrans;
            int operand = firstOp;
            int balanceAfter = bAfter;

        }

        public string TheDate { get; set; }
        public string TypeOfTrans { get; set; }
        public int FirstOp { get; set; }
        public int BAfter { get; set; }


    }
}
