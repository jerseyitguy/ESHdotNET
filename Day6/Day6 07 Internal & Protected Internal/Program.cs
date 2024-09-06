//Internal and Protected Internal Access Modifiers

//A member with internal access modifier is a visible any
//where with in the containing assembly. Its a compile time error
//to access , an internal member form outside the containing assembly.

//Protected internal members can be accessed by any code in the assembly
//in which it is declared, or from within a derived class in another assembly.
//It is a combination of protected and internal.
//If you have understood protected and internal,
//this should be very easy to follow.


using System;
using Day6_07._1_ClassLibrary;

namespace Day6_07_Internal___Protected_Internal
{
    /*
       // Derived class within the same assembly
       public class DerivedClassSameAssembly : BaseClass
       {

           public void AccessMembers()
           {
              // To be Told
              // Console.WriteLine(InternalMember);              // Accessible within the same assembly
               Console.WriteLine(ProtectedInternalMember);     // Accessible within the same assembly and as a derived class
           }
       }

       // Class within the same assembly, but not derived
       public class NonDerivedClassSameAssembly
       {
           public void AccessMembers()
           {
               BaseClass baseClass = new BaseClass();
               // To Be told
              //  Console.WriteLine(baseClass.InternalMember);              // Accessible within the same assembly
               //Console.WriteLine(baseClass.ProtectedInternalMember);     // Accessible within the same assembly
           }
       }
    */
    public class Program
    {


        public static void Main(string[] args)
        {
            // Instance of BaseClass
            BaseClass baseClass = new BaseClass();
            baseClass.DisplayMembers();

            // Instance of DerivedClassSameAssembly
            DerivedClassSameAssembly derivedSameAssembly = new DerivedClassSameAssembly();
            derivedSameAssembly.AccessMembers();

            // Instance of NonDerivedClassSameAssembly
            NonDerivedClassSameAssembly nonDerived = new NonDerivedClassSameAssembly();
            nonDerived.AccessMembers();

            // Instance of DerivedClassDifferentAssembly
            DerivedClassDifferentAssembly derivedDifferentAssembly = new DerivedClassDifferentAssembly();
            derivedDifferentAssembly.AccessMembers();
        }
    }

}
