using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesOOP
{
    [Serializable]
    public abstract class Shape 

    {
       
        public Point Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        

        public abstract double CalculateArea();

        public abstract void Paint(Graphics graphics, Color color);
        

    }

    [Serializable]
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            
            this.Width = width;
            this.Height = height;
        }
        


        public override void Paint(Graphics graphics, Color color)
        {

            using (var brush = new SolidBrush(color))
            using (var pen = new Pen(brush, 3))


                graphics.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

    }


    [Serializable]
    public class Ellipse : Shape
    {
        public Ellipse(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }





        public override void Paint(Graphics graphics, Color color)
        {

            using (var brush = new SolidBrush(color))
            using (var pen = new Pen(brush, 3))


                graphics.DrawEllipse(pen, Position.X, Position.Y, Width, Height);
        }

        public override double CalculateArea()
        {
            return Width / 2.0 * Height / 2.0 * Math.PI;
        }

    }

    [Serializable]
    public class Triangle : Shape
    {
            public Triangle (int width, int height)
            {
                this.Width = width;
                this.Height = height;
            }





            public override void Paint(Graphics graphics, Color color)
            {

              using (var brush = new SolidBrush(color))
              using (var pen = new Pen(brush, 3))
              {

                graphics.DrawLine(pen, Position.X + (Width / 2), Position.Y, Position.X + Width, Position.Y + Height);
                graphics.DrawLine(pen, Position.X + (Width / 2), Position.Y, Position.X, Position.Y + Height);
                graphics.DrawLine(pen, Position.X, Position.Y+Height, Position.X + Width, Position.Y + Height);

              }
            }

            public override double CalculateArea()
            {
                return (Width * Height) /2.0;
            }
            
    }


    
}
