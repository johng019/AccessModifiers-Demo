using System;
using System.Collections.Generic;
using System.Text;
using AccessDemo;

namespace ConsoleUI
{
    // Derived class outside of base class assembly
    class OutsideofAssemblyClass : AccessDemoTypes
    {
        public void GetOutsideAssemblyClassMethods()
        {
            PublicModifier();
            ProtectedModifier();
            ProtectedInternalModifier();
            
        }
    }
}
