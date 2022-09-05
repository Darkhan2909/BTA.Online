using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTA.Online.BLL
{
    public class Account
    {
        public int AccountId { get; set; }
        public string IBAN { get; set; }

        public int Currency { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        private double Balance_;
        public double Balance
        {
            get
            {
                return Balance_;
            }
            set
            {
                if (value < 0)
                {
                    Balance_ = 0;
                }
                else
                {
                    Balance_ = value;
                }
            }
        }

        public string GetCurrency
        {
            get
            {
                if (Currency == 1)
                {
                    return "tenge";
                }
                if (Currency == 2)
                {
                    return "dollar";
                }
                else
                {
                    return Currency.ToString();
                }
            }

            set
            {
                //double balance = Balance_;
            }
        }
    }
}
