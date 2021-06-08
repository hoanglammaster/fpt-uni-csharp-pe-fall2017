using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1_A
{
    public delegate void Notify (object sender, float newValue);
    class Payment : ITax
    {
        public event Notify AmountChanged;
        

        float  amount;
        public float Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (AmountChanged != null)
                {
                    AmountChanged(this,value);
                }
                amount = value;
            }
        }
        public Payment()
        {
        }

        public Payment(float amount)
        {
            this.amount = amount;
        }

        public float ComputeTax()
        {
            return Amount / 10;
        }
        
    }
}
