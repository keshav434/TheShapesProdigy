using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    sealed class Rectangle : Shape
    {
        double _Edges1 = 4;
        double _Vertices1 = 4;
        public override double Edges1 { get => this._Edges1; set => this._Edges1 = value; }
        public override double Vertices1 { get => _Vertices1; set => _Vertices1 = value; }

        public override double Area()
        {

            return (Height * Width);
        }

        public override double Perimeter()
        {
            return ( 2*Height+2*Width);
        }


        public new  void QuizQuestion(String shapetype, int questionnumber, int questiontype)
        {
            Console.WriteLine("A Square has " + Edges1 + " Edges and " + Vertices1 + " Vertices.");
            base.QuizQuestion("Square", questionnumber, questiontype);

        }


    }
}

