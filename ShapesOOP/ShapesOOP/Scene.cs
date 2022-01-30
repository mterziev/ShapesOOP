using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesOOP
{
    [Serializable]
    class Scene
    {
        private List<Shape> _shapes = new List<Shape>();
        private List<Shape> _selectedshapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void RemoveShape()
        {
            foreach (var shape in _selectedshapes)
            {
                _shapes.Remove(shape);


            }

        }
        public void ChangeShape(Color color, int width, int height)
        {
            foreach (var shape in _selectedshapes)
            {

                shape.Color = color;
                shape.Width = width;
                shape.Height = height;

            }
        }

        public void AddSelectedShape(Point location)
        {
            _selectedshapes = _shapes
                        .Where(r => r.Position.X < location.X &&
                                    r.Position.Y < location.Y &&
                                   (r.Position.X + r.Width) > location.X &&
                                  (r.Position.Y + r.Height) > location.Y
                        )
                        .ToList();

        }
        public void ShapeInfo()
        {
            foreach (var shape in _selectedshapes)
            {
                FormShapeInfo formshapeinfo = new FormShapeInfo();
                formshapeinfo.labelSize.Text += "(" + Convert.ToString(shape.Width) + "," + Convert.ToString(shape.Height) + ")";
                formshapeinfo.labelPosition.Text += "(" + Convert.ToString(shape.Position.X) + "," + Convert.ToString(shape.Position.Y) + ")";
                formshapeinfo.labelArea.Text += Convert.ToString(shape.CalculateArea());
                
                


                formshapeinfo.Show();

            }
        }

        public void ShapePosition(Point position)
        {
            foreach (var shape in _selectedshapes)
            {
                shape.Position = position;
            }
        }

        public void Paint(Graphics graphics)
        {
            foreach (var shape in _shapes)
                shape.Paint(graphics, shape.Color);
        }



    }
}
