using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_SpecialExample
{
    internal class CustomErrors
    {

        //fields
        //Error Code - message
        string _errorCode;
        string _errorMessage;


        //constructor
        public CustomErrors(string errorCode, string errorMessage)
        {
            _errorCode = errorCode;
            _errorMessage = errorMessage;
        }//CustomError


        //properties
        public string ErrorCode { get => _errorCode; }
        public string ErrorMessage { get => _errorMessage; }
        



        

        

    }//end of the class
}//end of namespace
