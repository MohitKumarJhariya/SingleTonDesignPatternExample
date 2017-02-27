using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonDesignPattern.UserModule;
namespace SingleTonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User userObj = new User();
            userObj.MakePayment();
            User userObj1 = new User();
            userObj1.MakePayment();

        }
    }
}
