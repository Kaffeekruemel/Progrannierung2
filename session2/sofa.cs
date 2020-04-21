using System;

namespace session2
{
    public class Sofa : IObject // wenn in der klammer nicht  public string Color {get; set; } steht dann "strg" + "." drücken
    {
        public string Color { get ; set ; }
        public string Material { get ; set ; }

        public Sofa (string color, string material)
        {
            Color = color;
            Material = material;
        }



        public void Print()
        {
             Console.WriteLine($"Sofa = Color: {Color}, Material: {Material}");
        }

        /*public void Print() => Console.WriteLine($"Sofa = Color: {Color}, Material: {Material}");
        --> mögliche schreibweise ohne geschweifte klammern*/
    }
}