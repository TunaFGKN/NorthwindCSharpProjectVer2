using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Abstract: Interface, Abstract Class, Base Class -> Referans tutucular
        //Concrete: Somut
        static void Main(string[] args)
        {
            
            
            //CategoryManagerTest();
            //ProductManagerTest();
        }

        //private static void CategoryManagerTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}
        //private static void ProductManagerTest()
        //{          
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetProductDetails();
        //    if (result.Success==true)
        //    {
        //        foreach (var product in productManager.GetProductDetails().Data)
        //        {
        //            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
            
        //}
    }
}