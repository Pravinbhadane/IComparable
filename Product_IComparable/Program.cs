
using Product_IComparable;
using System.Numerics;
public class Program
{

    static void Main(string[] args)
    {
        Product p1 = new Product(50000, "Laptop");
        Product p2 = new Product(30000, "Mobile");

        int result = p1.CompareTo(p2);

        if (result < 0)
        {
            Console.WriteLine($"Price of first product  is less than second product");
        }
        else if (result > 0)
        {
            Console.WriteLine("First Product Price is higher than second");
        }
        else
        {
            Console.WriteLine("First Product & Secomnd Product has same Price");
        }
    }
}