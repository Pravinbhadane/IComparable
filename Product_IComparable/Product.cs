using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_IComparable
{
      public class Product : IComparable<Product>
        {
            private int price;
            private string name;
            public Product(int price, string name)
            {
                this.price = price;
                this.name = name;
            }

            public int CompareTo(Product other)
            {
                
                if (this.price < other.price)
                {
                    return -1;
                }
                else if (this.price > other.price)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

      
        public override string ToString()
            {
                return $"Product= {name}  Price=  {price}";
            }
        }

    
}
