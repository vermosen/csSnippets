using System;

namespace readblacktree
{
    public class Tree 
    { 
        private class Node 
        {
            Node m_lhs;
            Node m_rhs;
            IComparable value;
        };
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
