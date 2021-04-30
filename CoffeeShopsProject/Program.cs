using CoffeeShopsProject.Concrete;
using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;
using ConsoleApp1.Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            byte choice = 0;            
            Console.Write("Press 1 to save to Starbucks DataBase and 2 to save to Nero DataBase:");
            choice = Convert.ToByte(Console.ReadLine());
            if(choice==1)
            {
                saveStarbucks();
            }
            if(choice==2)
            {
                saveNero();
            }            
        }
        static Customer getParameters()
        {
            Console.Write("Please enter the first name:");
            string firstName = Console.ReadLine();
            Console.Write("Please enter the last name:");
            string lastName = Console.ReadLine();
            Console.Write("Please enter the Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the date of birth:");
            DateTime dateOfBirth = new DateTime();
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Please enter the nationality id:");
            string nationalityId = Console.ReadLine();

            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Id = id,
                DateOfBirth = dateOfBirth,
                NationalityId = nationalityId
            };
            return customer;
        }

        static void saveStarbucks()
        {
            var customerCheckManager = new CustomerCheckManager();
            var customerManagerStarbucks = new StarbucksCustomerManager(customerCheckManager);
            customerManagerStarbucks.Save(getParameters());
        }

        static void saveNero()
        {
            var customerManagerNero = new NeroCustomerManager();
            customerManagerNero.Save(getParameters());
        }
 
    }  
}
