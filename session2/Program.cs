using System;

namespace session2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair chair = new Chair("red", "baloon");
            chair.Print();

            Sofa sofa = new Sofa ( "Green","wood");
            sofa.Print();
        } 
    }
}
