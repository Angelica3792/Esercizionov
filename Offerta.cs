using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizionov
{
    internal partial class Prodotti : Product
    {
        public Prodotti(int code) : base(code)
        {
        }

        public Prodotti(double price) : base(price)
        {
        }

        public Prodotti(string description, int code) : base(description, code)
        {
        }

        public Prodotti(int Code, string Description, double Price, double Discount, string description = null) : base(Code, Description, Price, Discount, description)
        {
        }
    
    
    }



}



