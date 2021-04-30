using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
