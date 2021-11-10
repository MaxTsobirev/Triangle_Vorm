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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);//считываем значение стороны А
            b = Convert.ToDouble(txtB.Text);//считываем значение стороны А
            c = Convert.ToDouble(txtC.Text);//считываем значение стороны А
            Triangle triangle = new Triangle(a, b, c);//создаем обьекты класса triangle с тем же именем
            listView1.Items.Add("Сторона а");//добавляем соответствующие ячейки в коллекцию items обьекта lstview1
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());//методы по выводу сторон а б с
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimetr()));//выводим периметр
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));//выводим значение площади
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.TriangleH()));
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[5].SubItems.Add("Не существует");



        }
    }
}
