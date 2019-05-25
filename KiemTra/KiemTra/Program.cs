using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            double result =0;
            List<Product> product = new List<Product>();
            MobilePhone mobile1 = new MobilePhone(1,"Iphone 5",1.3,"Abc");
            MobilePhone mobile2 = new MobilePhone(2,"Iphone 6",2.3,"Abc");
            MobilePhone mobile3 = new MobilePhone(3,"Iphone 7",3.3,"Abc");
            Book book1 = new Book(1, "Sach c#", 8.0, "Sack");
            Book book2 = new Book(2, "Sach c++", 9.0, "Sack");
            Book book3 = new Book(2, "Sach c--", 10.0, "Sack");
            product.Add(mobile1);
            product.Add(mobile2);
            product.Add(mobile3);
            product.Add(book1);
            product.Add(book2);
            product.Add(book3);
            foreach (Product item in product)
            {
                result += item.price;
            }
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
