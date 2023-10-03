using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Text_Game
{
    internal static class Render
    {
        
        public static List<String> asci { get;}
        // wenn two layer overlap the layer with the higher index value will be used
        public static Layer[] layers = new Layer[]
        {
            new Layer("Envirment",File.ReadAllText("C:\\Users\\bromo\\source\\repos\\Text_Game\\TestRender1.txt")),
            new Layer("UI",File.ReadAllText("C:\\Users\\bromo\\source\\repos\\Text_Game\\TestRender2.txt"))
        
        };
        // updates the screen with a new render 
        
        public static void update() 
        {
            string FinalAsci = layers[0].asci;
            FinalAsci += layers[1];
            Console.WriteLine(FinalAsci);

            for (int i = 0; i < FinalAsci.Length; i++)
            {
                if (layers[1].asci[i] != char.Parse(""))
                {
                    FinalAsci[i]. = layers[1].asci[i];
                }
            }
        }
    }
     
    struct Layer
    {
        public string name;
        
        public string asci;
        public Layer(string name,string asci)
        {
            this.name = name;

            this.asci = asci;
        }
    }
}
