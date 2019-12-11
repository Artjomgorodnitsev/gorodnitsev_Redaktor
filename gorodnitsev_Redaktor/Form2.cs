using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorodnitsev_Redaktor
{
    public partial class Form2 : Form
    {
        Color colorResult;
        Color color;

        public Form2()
        {
            InitializeComponent();

            hscrollBar_red.Tag = numericUpDown_red;
            hscrollBar_green.Tag = numericUpDown_green;
            hscrollBar_blue.Tag = numericUpDown_blue;


            numericUpDown_red.Tag = hscrollBar_red;
            numericUpDown_green.Tag = hscrollBar_green;
            numericUpDown_blue.Tag = hscrollBar_blue;


            numericUpDown_red.Value = color.R;
            numericUpDown_green.Value = color.G;
            numericUpDown_blue.Value = color.B;

            


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void HscrollBar_red_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void NumericUpDown_red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar  = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void HscrollBar_green_Scroll_1(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void NumericUpDown_green_ValueChanged_1(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void HscrollBar_blue_Scroll_1(object sender, ScrollEventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void NumericUpDown_blue_ValueChanged_1(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }



        private void UpdateColor()
        {
            colorResult = Color.FromArgb(hscrollBar_red.Value, hscrollBar_green.Value, hscrollBar_blue.Value);
            pictureBox1.BackColor = colorResult;
        }

        private void ButtonOther_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                hscrollBar_red.Value = colorDialog.Color.R;
                hscrollBar_green.Value = colorDialog.Color.G;
                hscrollBar_blue.Value = colorDialog.Color.B;

                colorResult = colorDialog.Color;

                UpdateColor();
                
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.currentPen.Color = colorResult;
            Close();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
