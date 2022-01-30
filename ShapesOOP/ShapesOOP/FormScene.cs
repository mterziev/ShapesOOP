using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace ShapesOOP
{
    public partial class FormScene : Form
    {
        public FormScene()
        {
            InitializeComponent();
        }

        
        int width;
        int height;
        Color color;
      

           Scene scene = new Scene();

     

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FormShapeSize formshapesize = new FormShapeSize();
            if (formshapesize.ShowDialog() == DialogResult.OK)
            {

                width = formshapesize.width;
                height = formshapesize.height;
                color = formshapesize.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShapeSize formshapesize = new FormShapeSize();

            formshapesize.textWidth = width.ToString();
            formshapesize.textHeight = height.ToString();
            formshapesize.Color = color;

            if (formshapesize.ShowDialog() == DialogResult.OK)
            {

                width = formshapesize.width;
                height = formshapesize.height;
                color = formshapesize.Color;
            }
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left) && radioButtonRectangle.Checked)
            {
                
                var rectangle = new Rectangle(width, height);
                rectangle.Position = e.Location;
                rectangle.Color = color;

                scene.AddShape(rectangle);
         
        
            }
            if (e.Button.Equals(MouseButtons.Left) && radioButtonEllipse.Checked)
            {
                
                var ellipse = new Ellipse(width, height);
                ellipse.Position = e.Location;
                ellipse.Color = color;

                scene.AddShape(ellipse);
            

       
            }
            if (e.Button.Equals(MouseButtons.Left) && radioButtonTriangle.Checked)
            {
                var triangle = new Triangle(width, height);
                triangle.Position = e.Location;
                triangle.Color = color;

                scene.AddShape(triangle);
        
            }
            if (e.Button.Equals(MouseButtons.Right) && radioButtonDelete.Checked)
            {
                scene.AddSelectedShape(e.Location);
                scene.RemoveShape();
            }

            if (e.Button.Equals(MouseButtons.Right) && radioButtonSize.Checked)
            {

                scene.AddSelectedShape(e.Location);
                scene.ChangeShape(color, width, height);
                
            }
            if (e.Button.Equals(MouseButtons.Right) && radioButtonInfo.Checked)
            {
               
                scene.AddSelectedShape(e.Location);
                scene.ShapeInfo();
            }
            Invalidate();
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right) && radioButtonPosition.Checked)
            {
                scene.AddSelectedShape(e.Location);

            }

        }
        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right) && radioButtonPosition.Checked)
            {
                scene.ShapePosition(e.Location);
                Invalidate();
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, scene);
                stream.Close();
            }
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                scene = (Scene)formatter.Deserialize(stream);
                stream.Close();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            scene.Paint(e.Graphics);

        }

        
    }
}
