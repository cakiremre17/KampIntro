﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 3;
            product1.UnitPrice = 500;

            ProductManager productmanager = new ProductManager();
            productmanager.Add(product1);


            
        }
    }
}
