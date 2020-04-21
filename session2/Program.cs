using System;
using System.Collections.Generic;

namespace session2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IObject> objects = new List<IObject>();

           objects.Add( new Chair("red", "baloon"));
           objects.Add( new Chair("gold", "gold"));
           objects.Add( new Sofa("blau", "teer"));
            
            foreach(var o in objects)
            {
               o.Print();
            }

            objects.ForEach(o => o.Print());

            objects.Find(o => o.Color =="Red").Print();
            
        } 
    }
}
