using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiralCoder
{
    /// <summary>
    /// Класс, обеспечивающий удобство использования DataGridView
    /// </summary>
    class DGV
    {
        /// <summary>
        /// Заполняет DataGridView столбцами и строками
        /// </summary>
        /// <param name="column"> Количество столбцов </param>
        /// <param name="rows"> Количество строк </param>
        /// <param name="dataGridView"> Обрабатываемый DataGridView </param>
        public static void Create(int column, int rows, DataGridView dataGridView)
        {
            // кусок дальше делает красоту
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            AddColumns(column, dataGridView);
            AddRows(rows, dataGridView);
        }

        /// <summary>
        /// Добавление стролбцов в DataGriView
        /// </summary>
        /// <param name="n"> Количество столбцов </param>
        /// <param name="dataGridView"> Обрабатываемый DataGriView </param>
        private static void AddColumns(int n, DataGridView dataGridView)
        {
            DataGridViewColumn column;
            for (int i = 0; i < n; i++)
            {
                column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Column" + i.ToString(),
                    Name = "Column" + i.ToString(),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };

                dataGridView.Columns.Add(column);
            }

        }

        /// <summary>
        /// Добавляет строки в DataGridView
        /// </summary>
        /// <param name="m"> Количество строк </param>
        /// <param name="dataGridView"> Обрабатываемый DataGriView </param>
        private static void AddRows(int m, DataGridView dataGridView)
        {
            for (int i = 0; i < m; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].HeaderCell.Value = "Row" + i.ToString();
            }
        }

        /// <summary>
        /// Метод считывающий матрицу из указанного DataGridView в массив.
        /// </summary>
        /// <param name="dataGridView">DataGridView Из которого считываем матрицу.</param>
        /// <returns> Возвращает массив </returns>
        public static string[,] Read(DataGridView dataGridView)
        {
            string[,] array;
            // создаём новый массив размера dataGridView.RowCount на dataGridView.ColumnCount
            // где RowCount количество строк у элемента, а ColumnCount количество столбцов
            array = new string[dataGridView.RowCount, dataGridView.ColumnCount];
            try //отлов исключений
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        //Преобразуем значения из ячеек в числа, и пишем в массив
                        //Если не число то происходит вызов исключения и его обработка
                        array[i, j] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception e) //обработка пойманного исключения
            {
                throw new Exception(e.Message + "\n(Использование букв и символов недопустимо!)");
                // Вариант ниже красивее :3
                // MessageBox.Show(e.Message + "\n(Использование букв и символов недопустимо!)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return array;
        }

        /// <summary>
        /// Метод записывающий матрицу из массива в указанный DataGridView
        /// </summary>
        /// <param name="array">Матрица которую выводим в DataGridView</param>
        /// <param name="dataGridView">DataGridView в который выводим</param>
        public static void Write(string[,] array, DataGridView dataGridView)
        {
            //указываем контроллу в который пишем количество строк и столбцов
            dataGridView.RowCount = array.GetLength(0);
            dataGridView.ColumnCount = array.GetLength(1);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }
    }
}
