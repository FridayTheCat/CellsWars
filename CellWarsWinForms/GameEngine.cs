using System;

namespace CellsGame
{
    internal class GameEngine
    {
        private bool[,] field;
        private readonly int rows;
        private readonly int cols;

        public uint currientGen { get; private set; }

        //Случайная генерация первого поколения при инициализации
        public GameEngine(int rows, int cols, int density)
        {
            this.rows = rows;
            this.cols = cols;   
            field = new bool[cols, rows];
            Random random = new Random();

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;
                }
            }

        }

        //Устарел. Использовался для просчета смертей и рождения без войны, для одной фракции
      /*  public void NextGen()
        {

            var newfield = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 3)
                    {
                        newfield[x, y] = true;
                    }
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        newfield[x, y] = false;
                    }
                    else
                    {
                        newfield[x, y] = field[x, y];
                    }
                }
            }
            field = newfield;
            currientGen++;
        } */

        //Просчет смертей и рождений клеток после пойны
        public void NextGenAfterWar(bool[,] fieldAfterWar)
        {

            var newfield = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = fieldAfterWar[x, y];

                    if (!hasLife && neighboursCount == 3)
                    {
                        newfield[x, y] = true;
                    }
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        newfield[x, y] = false;
                    }
                    else
                    {
                        newfield[x, y] = fieldAfterWar[x, y];
                    }
                }
            }
            field = newfield;
            currientGen++;
        }

        //Возврат текущего поколений
        public bool[,] GetCurrentGen()
        {
            var result = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = field[x, y];
                }
            }
            return result;
        }

        //Логика подсчета соседей клетки
        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }
            return count;
        }

        //Валидация позиции мыши при добавлении или удалении клеток
        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        //Метод связывающий валидацию и добавление/удаление клеток
        private void UpdateCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y))
            {
                field[x, y] = state;
            }
        }

        //Добавление клеток
        public void AddCell (int x, int y)
        {
            UpdateCell(x, y, true);
        }

        //Удаление клеток
        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, false);
        }

    }

}
