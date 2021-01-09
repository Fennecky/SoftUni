using Nakov.TurtleGraphics;
using System;

namespace NuGet_Turtle_Proj
{
    class Program
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
