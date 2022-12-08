using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Генеральский_практическая_6;

namespace Генеральский_практическая_5
{
    class Equilateral : Triangle//Triangle - базовый класс(родитель).После двоеточия мы указываем базовый класс для данного касса.
    {//При наследовании не передаются только конструкторы базового класса
        // Equilateral - производный класс,Triangle - базовый класс
        public Equilateral(int A) : base(A, A, A)
        {
           
        }
        public double CalculateSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
