using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizionov
{
    public class Product
    {
        public Product(int Code, string Description, double Price, double Discount, string description = null)
        {
            this.Description = description;
        }
        public int Code { get; }

        public Product(int code)
        {
            Code = code;
        }

        public string Description { get; set; }

        public Product(string description, int code)
        {
            Description = description;
            Code = code;
        }

        public double Price { get; set; }

        public Product(double price)
        {
            Price = price;
        }

        public double Discount { get; set; }

           }
    }

