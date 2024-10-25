using Core.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Store
    {
        public Product[] products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }


       


        public void RemoveProductByNo(int no)
        {
            Product[] newProducts = new Product[0];
            foreach (var product in products)
            {
                if (product.No != no)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = product;
                }
            }

            products = newProducts;
        }


        public void GetProduct(int no)
        {


            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    Console.WriteLine($"Product found: No  {products[i].No}, Name  {products[i].Name}, Price  {products[i].Price}, Type  {products[i].Type}");
                    return;
                }
            }

            Console.WriteLine("Mehsul tapilmadi");
        }




        
        

        public Product[] FilterProductsByType(ProductType type)
        {
            Product[] foundproducts = new Product[0];
            foreach (var product in products)
            {
                if (product.Type == type)
                {
                    Array.Resize(ref foundproducts, foundproducts.Length + 1);
                    foundproducts[foundproducts.Length - 1] = product;
                }
            }

            return foundproducts;
        }



        public Product[] FilterProductByName(string name)
        {
            Product[] filteredProducts = new Product[0];
            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[filteredProducts.Length - 1] = product;
                }
            }

            return filteredProducts;
        }
        public void ShowProduct()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Name + " "+product.Price +" "+ product.No);
            }
        }


    }
}
