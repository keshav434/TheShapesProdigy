using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    sealed class Square : Shape
    {
        double _Edges1=4;
        double _Vertices1=4;
        public override double Edges1 { get => this._Edges1; set => this._Edges1 = value; }
        public override double Vertices1 { get => _Vertices1; set => _Vertices1 = value; }
       
        public override double Area()
        {
            
            return (Height * Height); 
        }

        public override double Perimeter()
        {
            return (4 * Height);
        }

        
        public new void QuizQuestion(String shapetype, int questionnumber, int questiontype)
        {
            Console.WriteLine("A Rectangle has " + Edges1 + " Edges and " + Vertices1 + " Vertices.");
            base.QuizQuestion("Rectangle", questionnumber, questiontype);

        }


    }
}
