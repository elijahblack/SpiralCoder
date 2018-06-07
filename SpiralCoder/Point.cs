using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    /// <summary>
    /// Класс точки на плоскости
    /// </summary>
    class Point
    {
        private int x; 
        private int y; 

        /// <summary>
        /// Конструктор класса точки на плоскости
        /// </summary>
        /// <param name="x"> Координата X </param>
        /// <param name="y"> Координата Y </param>
        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        /// <summary>
        /// Метод итерации выбранной переменной на выбранный коэффициент
        /// </summary>
        /// <param name="coord"> Переменная оси </param>
        /// <param name="d"> Коэффициент итерации </param>
        public void Add(char coord, int d)
        {
            // принимает символьное значение оси и добавлет отклонение к нужной оси
            if (coord == 'x')
                x += d;             
            else if (coord == 'y')  
                y += d;
        }

        /// <summary>
        /// Координата X
        /// </summary>
        public int X { get => x; set => x = value; }

        /// <summary>                                   
        /// Координата Y                                
        /// </summary>                                  
        public int Y { get => y; set => y = value; } 
    }
}
