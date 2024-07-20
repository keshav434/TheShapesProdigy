using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TheShapesProdigy
{
    abstract class Shape
    {

        private double _base;
        private double _height;
        private double _width;
        private double _radius;



        public double Height
        {
            get => _height; set => _height = value;
        }
        public double Width
        {
            get => _width; set => _width = value;
        }


        public  double Radius
        {
            get => _radius; set => _radius = value;
        }

        public double Base
        {
            get => _base; set => _base = value;
        }

        public abstract double Edges1
        {
            get;
            set;
        }

         public abstract double Vertices1
        {
            get;
            set;
        }


        protected Shape()
        {
        }

       public abstract double Area();



        public abstract double Perimeter();
       



        public void QuizQuestion(string shapetype, int questionnumber, int questiontype)
        {
            string question;
            if (questiontype == 0)
            {
                question = "Perimeter";
            }
            else
            {
                question = "Area";
            }
            //new StreamReader(@"C:\Users\Keshav Premsagar\OneDrive\Desktop\P2.2-TheShapesProdigy-master\TheShapesProdigy\Shapes.csv"))
            using (StreamReader streader = new StreamReader(Directory.GetCurrentDirectory() + @"\Shapes.csv"))

            {
                int linecounter = 0;
                string csvline = string.Empty;
                string selectedline = string.Empty;
                while (!streader.EndOfStream)
                {
                    csvline = streader.ReadLine();
                    if (csvline.StartsWith(shapetype))
                    {
                        if (questionnumber == linecounter)
                        {
                            selectedline = csvline;
                            break;
                        }
                        linecounter++;
                    }

                }

                string[] parameters = selectedline.Split(',');
                if (shapetype == "Circle")
                {
                    Radius = Convert.ToDouble(parameters[1]);
                }
                else if (shapetype == "Rhombus"|| shapetype == "Triangle")
                {
                    Base = Convert.ToDouble(parameters[2]);
                    Height = Convert.ToDouble(parameters[1]);
                }
                else
                {
                    Height = Convert.ToDouble(parameters[1]);
                    if (shapetype == "Rectangle")
                    { 
                            Width = Convert.ToDouble(parameters[2]);
                        
                      
                    }
                }
               

                selectedline.Replace(shapetype, null);
                

                string printquestion = "What is " + question + " of the " + shapetype + " of size " + selectedline + "?";
                Console.WriteLine(printquestion);
            }
        }

    }


        

    }



