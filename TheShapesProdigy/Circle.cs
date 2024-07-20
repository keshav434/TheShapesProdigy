using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    sealed class    Circle : Shape
    {
        
        double _pie = 3.14;
        double _Edges1 = 4;
        double _Vertices1 = 4;
        public override double Edges1 { get => this._Edges1; set => this._Edges1 = value; }
        public override double Vertices1 { get => _Vertices1; set => _Vertices1 = value; }
        public double Pie { get => _pie; set => _pie = value; }

      

        public override double Area()
        {

            return Math.Round((Pie*Radius*Radius),2);
        }

        public override double Perimeter()
        {
            return (2*Pie*Radius);
        }

       

        public new void QuizQuestion(String shapetype, int questionnumber, int questiontype)
        {
            Console.WriteLine("A Circle has " + Edges1 + " Edges and " + Vertices1 + " Vertices.");
            base.QuizQuestion("Circle", questionnumber, questiontype);

        }


    }
}
