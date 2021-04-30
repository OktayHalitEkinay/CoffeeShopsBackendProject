using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopsProject.Abstract
{
  public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
