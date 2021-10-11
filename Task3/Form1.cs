using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rightTriangleReadybtn_Click(object sender, EventArgs e)
        {
            RightTriangle rightTriangle;
            try
            {
                rightTriangle = new RightTriangle(Convert.ToDouble(leg1tb.Text),
                    Convert.ToDouble(leg2tb.Text), Convert.ToDouble(hypotenusetb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch (ArgumentException exeption)
            {
                MessageBox.Show(exeption.Message);
                return;
            }
            rightTrianglePerimetertb.Text = rightTriangle.GetPerimeter().ToString();
            rightTriangleSquaretb.Text = rightTriangle.GetSquare().ToString();
        }

        private void isosTriangleReadybtn_Click(object sender, EventArgs e)
        {
            IsoscelesTriangle isoscelesTriangle;
            try
            {
                isoscelesTriangle = new IsoscelesTriangle(Convert.ToDouble(ribistriangltb.Text),
                    Convert.ToDouble(bottomistriangltb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch (ArgumentException exeption)
            {
                MessageBox.Show(exeption.Message);
                return;
            }
            isosTrianglePerimetertb.Text = isoscelesTriangle.GetPerimeter().ToString();
            isosTriangleSquaretb.Text = isoscelesTriangle.GetSquare().ToString();

        }
    }
}
