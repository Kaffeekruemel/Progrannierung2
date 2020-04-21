using System;

namespace session2
{
    public class Chair : IObject
    {
        public string Color {get; set; }

        public string Material { get;set;}

        public Chair(string color, string material)
        {
            Color = color;
            Material = material;
        }

        public void Print()
        {
            Console.WriteLine($"Chair = Color: {Color}, Material: {Material}");

        }
    }
    
}