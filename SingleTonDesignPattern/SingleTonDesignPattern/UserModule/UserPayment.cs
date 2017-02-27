using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonDesignPattern.UserModule
{
    public class UserPayment
    {
        #region Declaration
        private static Lazy<UserPayment> userPaymentObj = null;
        #endregion
        #region PrivateConstructor
        private UserPayment() { }
        #endregion
        #region Non Static Public Method
        public void MakePayment() {
            Console.WriteLine("Payment Done!");
            Console.ReadLine();
        }
        #endregion
        #region Static Public Method
        public static Lazy<UserPayment> createInstance() {
            return userPaymentObj ?? (userPaymentObj = new Lazy<UserPayment>(() => new UserPayment()));
        }
        #endregion
    }
}
