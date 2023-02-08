using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    class Student
    {
        int value;
        public Student() { }
        public void addition(ref double aver_mark, ref double result)
        {
            Console.Write("средняя оценка=");
            aver_mark = Convert.ToDouble(Console.ReadLine());
            Console.Write("значение сложения=");
            value = Convert.ToInt32(Console.ReadLine());
            result = aver_mark + value;
        }
        public void subtraction(out double aver_rat, out double effect)
        {
            Console.Write("средняя оценка=");
            aver_rat = Convert.ToDouble(Console.ReadLine());
            Console.Write("значение вычитания=");
            value = Convert.ToInt32(Console.ReadLine());
            effect = aver_rat - value;
        }
    }
    internal class Classes
    {
        static void Main(string[] args)
        {
            Console.Write("первая сигнатура сложения=");
            double meaning = Convert.ToDouble(Console.ReadLine());
            Console.Write("вторая сигнатура сложения=");
            double _meaning = Convert.ToDouble(Console.ReadLine());
            Student undergraduate = new Student();
            undergraduate.addition(ref meaning, ref _meaning);
            Console.WriteLine($"{meaning} {_meaning}");
            Console.Write("первая сигнатура вычитания=");
            double signature = Convert.ToDouble(Console.ReadLine());
            Console.Write("вторая сигнатура вычитания=");
            double _signature = Convert.ToDouble(Console.ReadLine());
            undergraduate.subtraction(out signature, out _signature);
            Console.WriteLine($"{signature} {_signature}");
        }
    }
}
