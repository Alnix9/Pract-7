using System;
using System.Windows;
using Генеральский_практическая_5;

namespace Генеральский_практическая_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }
        private void Square(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA1.Text, out int _A) & !int.TryParse(tbSideB1.Text, out int _B) & !int.TryParse(tbSideC1.Text, out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем считать их площадь", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Equilateral _square1 = new Equilateral(_A);
            double square = _square1.CalculateSquare();
            tbSquare.Text = Convert.ToString(square);
        }
        private void PlusOne(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA1.Text, out int _A) & !int.TryParse(tbSideB1.Text, out int _B) & !int.TryParse(tbSideC1.Text, out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем прибавлять к сторонам треугольника 1", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (tbTriangle1.Text != null)
            {
                Triangle _triangleplus = new Triangle(_A, _B, _C);
                _triangleplus++;
                tbTrianglePlus.Text = Convert.ToString(_triangleplus.A) + "," + Convert.ToString(_triangleplus.B) + "," + Convert.ToString(_triangleplus.C);
            }
        }
        private void MinusOne(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA2.Text, out int _A) & !int.TryParse(tbSideB2.Text, out int _B) & !int.TryParse(tbSideC2.Text, out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем вычитать 1 из сторон треугольника 2", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (tbTriangle2.Text != null)
            {
                Triangle _triangleminus = new Triangle(_A, _B, _C);
                _triangleminus--;
                tbTriangleMinus.Text = Convert.ToString(_triangleminus.A) + "," + Convert.ToString(_triangleminus.B) + "," + Convert.ToString(_triangleminus.C);
            }
        }
        private void CheckTriangle(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbCheckA.Text, out int _A) & !int.TryParse(tbCheckB.Text, out int _B) & !int.TryParse(tbCheckC.Text, out int _C))
            {
                MessageBox.Show("Впишите значения проверяемого треугольника прежде чем его проверять", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Triangle _trianglecheck = new Triangle(_A, _B, _C);
            if (_trianglecheck)
            {
                MessageBox.Show("Такой треугольник существует", "Проверка треугольника", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Такого треугольника не существует", "Проверка треугольника", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        private void PerimetrButton(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbDoublingA.Text, out int _A) & !int.TryParse(tbDoublingB.Text,out int _B) & !int.TryParse(tbDoublingC.Text,out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем узнавать их периметр" , "Вы нублан" , MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            else
            {
                 Triangle _triangle1 = new Triangle(_A,_B,_C);
                 _triangle1.Perimetr(_A, _B, _C);
                 tbPerimetr1.Text = Convert.ToString(_triangle1.A + _triangle1.B + _triangle1.C);
            }
        }
        private void DoublingButton(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA1.Text, out int _A) & !int.TryParse(tbSideB1.Text, out int _B) & !int.TryParse(tbSideC1.Text, out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем узнавать удваивать их", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                Triangle _doubling = new Triangle(_A, _B, _C);
                _doubling.Doubling(_A, _B, _C);
                tbDoublingA.Text = Convert.ToString(_doubling.A);
                tbDoublingB.Text = Convert.ToString(_doubling.B);
                tbDoublingC.Text = Convert.ToString(_doubling.C);
            }
        }
        private void SetParams1(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA1.Text, out int _A) & !int.TryParse(tbSideB1.Text, out int _B) & !int.TryParse(tbSideC1.Text, out int _C))
            {
                MessageBox.Show("Установите параметры", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Triangle _setParams1 = new Triangle(_A, _B, _C);
            _setParams1.SetParams(_A, _B, _C);
            tbTriangle1.Text = Convert.ToString(_setParams1.A) + "," + Convert.ToString(_setParams1.B) + "," + Convert.ToString(_setParams1.C);
        }
        private void SetParams2(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA2.Text, out int _A) & !int.TryParse(tbSideB2.Text, out int _B) & !int.TryParse(tbSideC2.Text, out int _C))
            {
                MessageBox.Show("Установите параметры", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Triangle _setParams2 = new Triangle(_A, _B, _C);
            _setParams2.SetParams(_A, _B, _C);
            tbTriangle2.Text = Convert.ToString(_setParams2.A) + "," + Convert.ToString(_setParams2.B) + "," + Convert.ToString(_setParams2.C);
        }
        private void About_Program(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5.(7практ) Использовать класс Triangle (треугольник) с полями-сторонами. " +
                "Создать \r\nпроизводный класс Equilateral (равносторонний), имеющий поле площади. \r\nОпределить метод вычисления площади.");
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}

   

