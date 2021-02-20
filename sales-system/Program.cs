using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product();
            p1.Name = "Hamburguesa";
            p1.Price = 15000;

            Product p2 = new Product();
            p2.Name = "Batido";
            p2.Price = 8000;

            Product p3 = new Product();
            p3.Name = "Salchipapa";
            p3.Price = 10000;


            Seller s1 = new Seller();
            s1.Name = "Pedro";
            s1.Age = 29;

            Seller s2 = new Seller();
            s2.Name = "Mateo";
            s2.Age = 37;

            Seller s3 = new Seller();
            s3.Name = "Hector";
            s3.Age = 23;


            Sale sale1 = new Sale();
            sale1.Product = p1;
            sale1.Seller = s1;
            sale1.Comments = "Without onion";

            Sale sale2 = new Sale();
            sale2.Product = p3;
            sale2.Seller = s2;
            sale2.Comments = "No sauce";

            Sale sale3 = new Sale();
            sale3.Product = p2;
            sale3.Seller = s3;
            sale3.Comments = "Without tomato";


            System.Console.WriteLine("Sales Total Amount = " + (sale1.Product.Price+sale2.Product.Price+sale3.Product.Price));

        }
    }
}
