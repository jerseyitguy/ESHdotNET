//Enums
/* If a program uses set of integral numbers, consider replacing them wit enums, which makes the program more
//Readable
// Maintainable

/* 
.1 Enums are enumerations.
.2 Enums are strongly typed constants. Hence, an 
explicit cast is needed to convert form enum type to an integral type
and vice verse. Also, an enum of on type cannot be implicitly assigned 
to an enum of another type even though the underlying value of their members
are the same.
.3 The default underlying type of an enum is int.
.4 The default value for first element is Zero and gets incremented by 1.
.5 It is possible to customize the underlying type and values.
.6 Enums are value types.
.7 Enum Keyword (all small letters) is used to create enumerations, 
where as Enum class, contains static Getvalues() and GetNames() methods 
which can be used to list Enum underlying type values and Names.
*/

using System;

namespace Day5_03_cEnumExamples
{
    public class Enums
    {
        public static void Main()
        {
            // Show
//int[] Values = (int[])Enum.GetValues(typeof(Gender));
            short[] Values = (short[])Enum.GetValues(typeof(Gender));

            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }
            string[] Names = Enum.GetNames(typeof(Gender));

            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }



    public enum Gender : short
    {
        Unknown = 1,
        Male = 5,
        Female = 23
    }


}
