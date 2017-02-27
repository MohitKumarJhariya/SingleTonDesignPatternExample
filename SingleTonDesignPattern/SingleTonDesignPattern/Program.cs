using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonDesignPattern.UserModule;
namespace SingleTonDesignPattern
{
    /// <summary>
    /// singleton design pattern states that a class only allows a single instance of itself to be created 
    /// </summary>
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
