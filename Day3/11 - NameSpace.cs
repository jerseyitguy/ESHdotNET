/*
We will learn 

Namespace basics
Using alias directive
Different namespace members

Why Namespaces 
Namespaces are used to organize your programs.

They also provide assistance in avoiding name clashes.

Namespaces
Namespaces don't correspond to file, directory or assembly names. They could be written in separate file and/ or separate assemblies and still belong to the same namespace.

Namespace can be nested in 2 ways

Namespace alias directives. Sometimes you may encounter a long namespace and wish to have it shorter. This could improve readability and still avoid name clashes with similarly named methods


Namespaces example 
*/

using System;
using ProjectA.TeamA;
// using PATA=ProjectA.TeamA;

class program
{
	public static void Main()
	{
		Console.WriteLine("Hello")
	ClassA.Print();
		ProjectA.TeamB.Print();
	}
}

namespace ProjectA
{
	namespace TeamA
	{
		class ClassA
		{
			public static void Print()
			{
				Console.WriteLine("TeamA Print Method")
			}
		}
	}
}

namespace ProjectA
{
	namespace TeamB
	{
		class ClassA
		{
			public static void Print()
			{
				Console.WriteLine("TeamB Print Method")
			}
		}
	}
}