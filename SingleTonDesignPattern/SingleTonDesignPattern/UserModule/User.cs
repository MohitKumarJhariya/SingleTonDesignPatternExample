using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonDesignPattern.UserModule
{
   public class User
    {
        #region Declaration
        private Lazy<UserPayment> userpaymentObj = null;
        #endregion
        #region Public constructor
        public User()
        {
            userpaymentObj = UserPayment.createInstance();
        }
        #endregion
        #region public Method
        public void MakePayment() {
            userpaymentObj?.Value?.MakePayment();
        }
        #endregion
    }
}
