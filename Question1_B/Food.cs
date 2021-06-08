using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1_B
{
    public delegate void Notify(object sender, float newValue);
    class Food : IFood
    {
        public event Notify AmountChanged;
        float amount;
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
                    AmountChanged(this, value);
                }
                amount = value;
            }
        }
        public float ComputeCalory()
        {
            return amount / 100 * 5;
        }
        
    }
}
