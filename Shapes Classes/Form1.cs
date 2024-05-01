using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length, breadth, ans;
            length = double.Parse(textBox1.Text);
            breadth = double.Parse(textBox2.Text);
            ans = Rectangle.Area(length, breadth);
            MessageBox.Show("The aera of a rectangle with a length of " + length.ToString() + " and breadth of " + breadth.ToString() + " is " + ans.ToString() + " units squared.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double length, breadth, ans;
            length = double.Parse(textBox1.Text);
            breadth = double.Parse(textBox2.Text);
            ans = Rectangle.Perimeter(length, breadth);
            MessageBox.Show("The perimeter of a rectangle with a length of " + length.ToString() + " and breadth of " + breadth.ToString() + " is " + ans.ToString() + " units.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double radius, ans;
            radius = double.Parse(textBox4.Text);
            ans = Circle.Area(radius);
            MessageBox.Show("The area of a circle with a radius of " + radius.ToString() + " is " + ans.ToString() + " units squared");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double radius, ans;
            radius = double.Parse(textBox4.Text);
            ans = Circle.Area(radius);
            MessageBox.Show("The circumfrence of a circle with a radius of " + radius.ToString() + " is " + ans.ToString() + " units");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double tbase, height, ans;
            tbase = double.Parse(textBox3.Text);
            height = double.Parse(textBox7.Text);
            ans = Triangle.Area(tbase, height);
            MessageBox.Show("The area of a triangle with a base of " + tbase.ToString() + " and height of " + height.ToString() + " is " + ans.ToString() + " units squared.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ans;
            s1 = double.Parse(textBox3.Text);
            s2 = double.Parse(textBox5.Text);
            s3 = double.Parse(textBox6.Text);
            ans = Triangle.Perimeter(s1, s2, s3);
            MessageBox.Show("The perimeter of a triangle is " + ans.ToString() + " units.");
        }
    }
}
