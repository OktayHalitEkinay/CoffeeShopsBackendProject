using ConsoleApp1.Abstract;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
