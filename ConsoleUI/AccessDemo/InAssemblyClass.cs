using System;
using System.Collections.Generic;
using System.Text;


namespace AccessDemo
{
    //Contained in a Class Library (DLL)
    // Derived class within same assembly as base class
    public class InAssemblyClass : AccessDemoTypes
    {
        public void GetAccessMethods()
        {
            PublicModifier();
            ProtectedModifier();
            InternalModifier();
            ProtectedInternalModifier();
            PrivateProtectedModifier();
            
           
        }
        
        
    }
}
