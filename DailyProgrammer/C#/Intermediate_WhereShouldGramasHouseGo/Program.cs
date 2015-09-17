using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_WhereShouldGramasHouseGo
{
    class Program
    {
        static void Main(string[] args)
        {
            float minDistance = 0.0f;
            var list = new List<Point>();
            var lines = File.ReadAllLines("input.txt").Skip(1).ToArray();
            lines = cleanLines(lines);

            for (int i = 0; i < lines.Length; i++)
            {
                var pt1 = ExtractPointFromString(lines[i]);
                var pt2 = new Point();
                for (int j = i + 1; j < lines.Length; j++)
                {
                    var success = false;
                    pt2 = ExtractPointFromString(lines[j]);
                    if (minDistance == 0.0f)
                    {
                        minDistance = Point.Distance(pt1, pt2);
                    }
                    else
                    {
                        var tempDistance = Point.Distance(pt1, pt2);
                        if (tempDistance < minDistance)
                        {
                            minDistance = tempDistance;
                            success = true;
                        }
                    }

                    if (success)
                    {
                        if (list.Count() == 0)
                        {
                            list.Add(pt1);
                            list.Add(pt2);
                        }
                        else
                        {
                            list.Clear();
                            list.Add(pt1);
                            list.Add(pt2);
                        }
                        success = false;
                    }
                }
            }

            var s = String.Format("({0}, {1}) ({2}, {3})", list[0].X, list[0].Y, list[1].X, list[1].Y);
            Console.WriteLine(s);
            Console.ReadLine();
        }

        private static string[] cleanLines(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
                lines[i] = lines[i].Substring(1, lines[i].Length - 2);
                //lines[i] = lines[i].Substring(1, lines[i].Length - 1);
            return lines;
        }

        private static Point ExtractPointFromString(string str)
        {
            var temp = str.Split(',');                 
            return new Point(float.Parse(temp[0]), float.Parse(temp[1]));
        }

    }
    
    class Point
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Point()
        {
            X = 0.0f;
            Y = 0.0f;
        }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public bool isNull() 
        {
            return (X == 0.0f && Y == 0.0f); 
        }

        public static float Distance(Point pt1, Point pt2)
        {
            return (float) Math.Sqrt(Math.Pow(pt1.X - pt1.Y, 2) + Math.Pow(pt2.X - pt2.Y, 2));
        }
    }
}
