using System;

namespace TheShapesProdigy
{
    class Program
    {
        static string shapetype = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("The Shapes Prodigy!");

            
            Console.WriteLine("=================");
            Console.WriteLine("THE  SHAPE  QUIZ");
            Console.WriteLine("=================");
            Console.WriteLine(" Enter Username :");
            string username = Convert.ToString(Console.ReadLine());

            Shape anyshape;
            int marks = 0;
            for (int i=0 ; i < 10 ; i++ )
            {
                
                Random rng = new Random();
                int shape = rng.Next(0, 5);
               
                int questiontype = rng.Next(0,2);
                int questionnumber = rng.Next(0,3);
                anyshape = retObj(shape);
                anyshape.QuizQuestion(shapetype, questionnumber, questiontype);
                double useranswer = Convert.ToDouble(Console.ReadLine());

                if (questiontype == 0)
                {
                    if (anyshape.Perimeter() == useranswer)
                    {
                        marks = marks + 10;

                    }
                }
                else
                {
                    if (anyshape.Area() == useranswer)
                    {
                        marks = marks+ 10;

                    }

                }
                       

            }
            Console.WriteLine(username + " ,you have scored: " + marks);
        }
        public static Shape retObj(int shape)        {
            if (shape == 0)
            {
                shapetype = "Square";
                return new Square();
            }
            else if (shape == 1)
            {
                shapetype = "Rectangle";
                return new Rectangle();
            }
            else if (shape == 2)
            {
               shapetype = "Triangle";
                return new Triangle();
            }
            else if (shape == 3)
            {
               shapetype = "Rhombus";
                return new Rhombus();
            }
            else 
            {
               shapetype = "Circle";
               return new Circle();
            }
          


        }        
        
    }
}
