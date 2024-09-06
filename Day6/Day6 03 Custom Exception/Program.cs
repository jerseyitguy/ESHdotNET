//Custom Exception - Steps

//1. Create a class that derives from system.Exception.Class. As a //convention end the class name with exception suffix.All.Net //exception end with exception suffix.
//2. Provide a public constructor, that takes in a string parameter. This constructor simply passes the string parameter to the base exception clas constructor.

using System;
using System.IO;
using System.Runtime.Serialization;

namespace Day6_03_Custom_Exception
{
    public class CustomExceptionsDemo
    {
        public static void Main()
        {
            try
            {
                // Attempt to throw a custom exception with a specific message
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                // Catch the custom exception and output its message to the console
                Console.WriteLine("Exception occurred  : {0}",ex.Message);

            }
        }

        [Serializable] // Indicates that this class can be serialized
        public class UserAlreadyLoggedInException : Exception
        {
            // Default constructor
            public UserAlreadyLoggedInException() : base()
            {
                // Calls the base class constructor (Exception) with no parameters
            }

            // Constructor that accepts a custom message
            public UserAlreadyLoggedInException(string message) : base(message)
            {
                // Calls the base class constructor with a custom message
            }

            // Constructor that accepts a custom message and an inner exception
            public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
            {
                // Calls the base class constructor with a custom message and an inner exception
            }

            // Constructor used for deserialization
            protected UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                // Calls the base class constructor with serialization info and streaming context
            }
        }
    }

}
