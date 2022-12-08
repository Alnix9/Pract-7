using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Генеральский_практическая_6
{
    internal class Triangle
    {
        private int _a;
        private int _b;
        private int _c;
        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public int Perimetr(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
            return a + b + c;
        }
        public int A
        {
            get => _a;
            set
            {
                _a = value;
            }
        }
        public int B
        {
            get => _b;
            set
            {
                _b = value;
            }
        }
       public int C
        {
            get => _c;
            set
            {
                _c = value;
            }
        }
        public void SetParams(int value)
        {
            A = value;
            B = value;
            C = value;
        }
        public void SetParams(int AValue,int BValue,int CValue)
        {
            A = AValue;
            B = BValue;
            C = CValue;
        }
        public void Doubling(int DoublingA,int DoublingB,int DoublingC)
        {
            A = DoublingA;
            B = DoublingB;
            C = DoublingC;
            A *= 2;
            B *= 2;   
            C *= 2;
        }

        public static bool operator true(Triangle Triangle)
        {
            Triangle trianglehave = new Triangle(Triangle.A, Triangle.B, Triangle.C);
            if (Triangle.A + Triangle.B > Triangle.C && Triangle.A + Triangle.C > Triangle.B && Triangle.B + Triangle.C > Triangle.A) return true;
                    else return false;
        }
        public static bool operator false(Triangle Triangle)
        {
            Triangle triangledoesnthave = new Triangle(Triangle.A, Triangle.B, Triangle.C);
            if (Triangle.A + Triangle.B < Triangle.C && Triangle.A + Triangle.C < Triangle.B && Triangle.B + Triangle.C < Triangle.A) return false;
            else return true;
        }
        public static Triangle operator ++(Triangle Triangle)
        {
            Triangle triangleplus = new Triangle(Triangle.A+1,Triangle.B+1,Triangle.C+1);
            return triangleplus;
        }
        public static Triangle operator --(Triangle Triangle)
        {
            Triangle triangleminus = new Triangle(Triangle.A - 1,Triangle.B - 1,Triangle.C - 1);
            return triangleminus;
        }
    }
}
