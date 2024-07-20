using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    sealed class Triangle : Shape
    {
        double _Edges1 = 3;
        double _Vertices1 = 3;
        public override double Edges1 { get => this._Edges1; set => this._Edges1 = value; }
        public override double Vertices1 { get => _Vertices1; set => _Vertices1 = value; }

      
        public override double Area()
        {

            return ((Base*Height)/2);
        }

        
        public override double Perimeter()
        {
            double Daigonal = Math.Sqrt(Base * Base + Height * Height);
            return (Base +Height + Daigonal );
        }

        public new  void QuizQuestion(String shapetype, int questionnumber, int questiontype)
        {
            Console.WriteLine("A Triangle has " + Edges1 + " Edges and " + Vertices1 + " Vertices.");
            base.QuizQuestion("Triangle", questionnumber, questiontype);

        }


    }



}
