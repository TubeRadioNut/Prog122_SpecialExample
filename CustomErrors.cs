using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_SpecialExample
{
    public class CustomErrors
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
        public string errorcode { get => _errorCode; }
        public string errormessage { get => _errorMessage; }

        //New : override TOString()
        //this will allow us to change what displays
        //when we call the ToString() on instanced object


        public override string ToString()
        {
            return $"{this._errorCode} - {this._errorMessage}";
        }
        



        

        

    }//end of the class
}//end of namespace
