using System;
using System.Collections.Generic;
using System.IO;


namespace TrainingJan21
{

    class ProductInformation<T, E>
    {
        T[] product_name;
        E[] product_type;
        int product_size;
        public ProductInformation(int product_size)
        {
            this.product_size = product_size;
            product_name = new T[product_size];
            product_type = new E[product_size];
        }       
        public void addProduct(T name, int position)
        {
            product_name[position] = name;
        }
        public void addProductDetails(E type, int position)
        {
            product_type[position] = type;
        }
        public void printProductDetails()
        {
            for (int i = 0; i < product_size; i++)
            {
                Console.WriteLine("Product Details:");
                Console.WriteLine("Product Name:");
                Console.WriteLine(product_name[i]);
                Console.WriteLine("Product Type:");
                Console.WriteLine(product_type[i]);
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ProductInformation<string, string> p = new ProductInformation<string, string>(3);
            p.addProduct("product-1", 0);
            p.addProduct("product-2", 1);
            p.addProduct("product-3", 2);
            p.addProductDetails("300", 0);
            p.addProductDetails("400", 1);
            p.addProductDetails("500", 2);
            p.printProductDetails();
            Console.ReadKey();
        }
    }
}
