using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo
{
    //Contained in a Class Library (DLL)
    //Base Class
    public class AccessDemoTypes 
    {
        public void PublicModifier()
        {
            Console.WriteLine("public void PublicModifier()");
        }

        private void PrivateModifier()
        {
            Console.WriteLine("private void PrivateModifier()");
        }

        protected void ProtectedModifier()
        {
            Console.WriteLine("protected void ProtectedModifier()");
        }

        internal void InternalModifier()
        {
            Console.WriteLine("internal void InternalModifier()");
        }

        protected internal void ProtectedInternalModifier()
        {
            Console.WriteLine("protected internal void ProtectedInternalModifier()");
        }

        private protected void PrivateProtectedModifier()
        {
            Console.WriteLine("private protected void PrivateProtectedModifier()");
        }
    }
}
