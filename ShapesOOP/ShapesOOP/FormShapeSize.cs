using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesOOP
{
    public partial class FormShapeSize : Form
    {
        public FormShapeSize()
        {
            InitializeComponent();
        }
        private void ShapeSize_Load_1(object sender, EventArgs e)
        {
     
            textBoxWidth.Text = textWidth;
            textBoxHeight.Text = textHeight;
          



        }
        
        public int width { get; set; }
        public int height { get; set; }
        public Color Color = Color.Black;
        public string textWidth { get; set; }
        public string textHeight { get; set; }

      
        

        private void buttonOK_Click_1(object sender, EventArgs e)
        {

            width = int.Parse(textBoxWidth.Text);
            height = int.Parse(textBoxHeight.Text);
            
            DialogResult = DialogResult.OK;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {

                Color = color.Color;
            }
        }
    

        
    }
}
