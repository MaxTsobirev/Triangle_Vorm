using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);//считываем значение стороны А
            b = Convert.ToDouble(txtB.Text);//считываем значение стороны А

            Triangle triangle = new Triangle(a, b );//создаем обьекты класса triangle с тем же именем
            listView1.Items.Add("Сторона а");//добавляем соответствующие ячейки в коллекцию items обьекта lstview1
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высота");

            listView1.Items[0].SubItems.Add(triangle.outputA());//методы по выводу сторон а б с
            listView1.Items[1].SubItems.Add(Convert.ToString(triangle.plosjad()));
            listView1.Items[2].SubItems.Add(Convert.ToString(triangle.h));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
