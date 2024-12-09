using System;

namespace MyConsoleApp
{
    public class TypeA
    {
        private int F = 10;
        internal int G = 20;
        public int H = 30;

        // Public method to access private field F
        public int GetF()
        {
            return F;
        }

        // Internal method to demonstrate internal access
        internal void ModifyG(int value)
        {
            G = value;
        }
    }
}
