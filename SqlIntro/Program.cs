﻿using System;
using System.Linq;

namespace SqlIntro
{
    class Program
    {
        static void Main(string[] args)
        {   
            var connectionString = "Server=localhost;Database=adventureworks;Uid=root;Pwd=Iam4bama:);"; //get connectionString format from connectionstrings.com and change to match your database
            var repo = new ProductRepository(connectionString);
            foreach (var prod in repo.GetProducts())
            {
                Console.WriteLine("Modified Date:" + prod.ModifiedDate.ToLongDateString() + " ");
            }

           
            Console.ReadLine();
        }

       
    }
}
