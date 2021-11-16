using System;

namespace type
{
    class Program
    {
        static void Main(string[] args)
        {
            Type a = typeof(string);
            Type b = typeof(int);
            Type c = typeof(float);
            System.Diagnostics.Debug.WriteLine(a.FullName);
            System.Diagnostics.Debug.WriteLine(b.FullName);
            System.Diagnostics.Debug.WriteLine(c.FullName);
        }
    }
}
