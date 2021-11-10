using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    class Triangle
    {
        public double a;//первая сторона
        public double b;//вторая сторона
        public double c;//третья сторона
    
        public Triangle(double A,double B,double C)//Конструктор
        {
            a = A;
            b = B;
            c = C;
        }
        public string outputA() //выводим сторону а,данный метод возвращает строковое значение
        {
            return Convert.ToString(a);//ссылка на внутреннее   поле обьекта класса
        }
        public string outputB()//выводим сторону б
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public double Perimetr()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double GetSetA//свойство позволяющее установить либо изменить значение стороны
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB//свойство позволяющее установить либо изменить значение стороны
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC//свойство позволяющее установить либо изменить значение стороны
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriange//позволяет установить, существует ли треугольник с такими сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return false;
                    else return true;
            }
     
        }
    }
}   
