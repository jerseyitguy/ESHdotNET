namespace Day6_07._1_ClassLibrary
{
    public class BaseClass
    {
        // Internal member: Accessible within the same assembly
        internal string InternalMember = "Internal Member";

        // Protected internal member: Accessible within the same assembly and by derived classes
        protected internal string ProtectedInternalMember = "Protected Internal Member";

        // Method to display members
        public void DisplayMembers()
        {
            Console.WriteLine(InternalMember);              // Accessible
            Console.WriteLine(ProtectedInternalMember);     // Accessible
        }
    }
        public class DerivedClassSameAssembly : BaseClass
    {
        public void AccessMembers()
        {
           // To be Told
            Console.WriteLine(InternalMember);              // Accessible within the same assembly
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
            Console.WriteLine(baseClass.InternalMember);              // Accessible within the same assembly
            Console.WriteLine(baseClass.ProtectedInternalMember);     // Accessible within the same assembly
        }
    }
      
     

    // Another assembly (imagine this class is in a different project)
    public class DerivedClassDifferentAssembly : BaseClass
    {
        public void AccessMembers()
        {
            // Console.WriteLine(InternalMember);  // NOT accessible: Internal members are not accessible from another assembly

            Console.WriteLine(ProtectedInternalMember);     // Accessible: Protected internal members are accessible by derived classes, even in different assemblies
        }
    }

}
