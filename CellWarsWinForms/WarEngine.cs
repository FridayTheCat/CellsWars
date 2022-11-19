
namespace CellsGame
{
    internal class WarEngine
    {
        private bool[,] fieldAfterWarBLUE;
        private bool[,] fieldAfterWarRED;
        private bool[,] fieldAfterWarGREEN;
        private readonly int cols;
        private readonly int rows;

        public WarEngine(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
        }

        //Логика войны
        public void War(bool[,] fieldBLUE, bool[,] fieldRED, bool[,] fieldGREEN)
        {
            fieldAfterWarBLUE = new bool[cols, rows];
            fieldAfterWarRED = new bool[cols, rows];
            fieldAfterWarGREEN = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    //Получение количества врагов для клетки
                    var EnemyForBLUECount = CountEnemyforBLUE(x, y, fieldBLUE, fieldRED, fieldGREEN);     // SUM, RED,  GREEN
                    var EnemyForREDCount = CountEnemyforRED(x, y, fieldBLUE, fieldRED, fieldGREEN);       // SUM, BLUE, GREEN
                    var EnemyForGREENCount = CountEnemyforGREEN(x, y, fieldBLUE, fieldRED, fieldGREEN);   // SUM, BLUE, RED

                    //Логика смертей в войне
                    if (EnemyForBLUECount[0] > 2)
                    {
                        for (int i = -3; i < 4; i++)
                        {
                            for (int j = -3; j < 4; j++)
                            {
                                var col = (x + i + cols) % cols;
                                var row = (y + j + rows) % rows;
                                fieldAfterWarBLUE[col, row] = false;
                                if (i>-2 && i<2 && j>-2 && j<2)
                                {
                                    if (EnemyForBLUECount[1] > EnemyForBLUECount[2])
                                    {
                                        fieldAfterWarRED[col, row] = true;
                                        fieldAfterWarGREEN[col, row] = false;
                                    }
                                    else if (EnemyForBLUECount[1] < EnemyForBLUECount[2])
                                    {
                                        fieldAfterWarRED[col, row] = false;
                                        fieldAfterWarGREEN[col, row] = true;
                                    }
                                    else
                                    {
                                        fieldAfterWarRED[col, row] = false;
                                        fieldAfterWarGREEN[col, row] = false;
                                    }
                                }
                            }
                        }  
                    }
                    else if (EnemyForREDCount[0] > 2)
                    {
                        for (int i = -3; i < 4; i++)
                        {
                            for (int j = -3; j < 4; j++)
                            {
                                var col = (x + i + cols) % cols;
                                var row = (y + j + rows) % rows;
                                fieldAfterWarRED[col, row] = false;
                                if (i > -2 && i < 2 && j > -2 && j < 2)
                                {
                                    if (EnemyForREDCount[1] > EnemyForREDCount[2])
                                    {
                                        fieldAfterWarBLUE[col, row] = true;
                                        fieldAfterWarGREEN[col, row] = false;
                                    }
                                    else if (EnemyForREDCount[1] < EnemyForREDCount[2])
                                    {
                                        fieldAfterWarBLUE[col, row] = false;
                                        fieldAfterWarGREEN[col, row] = true;
                                    }
                                    else
                                    {
                                        fieldAfterWarBLUE[col, row] = false;
                                        fieldAfterWarGREEN[col, row] = false;
                                    }
                                }
                            }
                        }
                    }
                    else if (EnemyForGREENCount[0] > 2)
                    {
                        for (int i = -3; i < 4; i++)
                        {
                            for (int j = -3; j < 4; j++)
                            {
                                var col = (x + i + cols) % cols;
                                var row = (y + j + rows) % rows;
                                fieldAfterWarGREEN[col, row] = false;
                                if (i > -2 && i < 2 && j > -2 && j < 2)
                                {
                                    if (EnemyForGREENCount[1] > EnemyForGREENCount[2])
                                    {
                                        fieldAfterWarBLUE[col, row] = true;
                                        fieldAfterWarRED[col, row] = false;
                                    }
                                    else if (EnemyForGREENCount[1] < EnemyForGREENCount[2])
                                    {
                                        fieldAfterWarBLUE[col, row] = false;
                                        fieldAfterWarRED[col, row] = true;
                                    }
                                    else
                                    {
                                        fieldAfterWarBLUE[col, row] = false;
                                        fieldAfterWarRED[col, row] = false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        fieldAfterWarBLUE[x, y] = fieldBLUE[x,y];
                        fieldAfterWarRED[x, y] = fieldRED[x,y];
                        fieldAfterWarGREEN[x, y] = fieldGREEN[x, y];
                    }
                }
            }
        }

        //Возврат поколений после войны
        public bool[,] GetAfterWarFieldBLUE()
        {
            var result = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = fieldAfterWarBLUE[x, y];
                }
            }
            return result;
        }

        public bool[,] GetAfterWarFieldRED()
        {
            var result = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = fieldAfterWarRED[x, y];
                }
            }
            return result;
        }
        public bool[,] GetAfterWarFieldGREEN()
        {
            var result = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = fieldAfterWarGREEN[x, y];
                }
            }
            return result;
        }

        //Логика посчета врагов для клеток
        private int[] CountEnemyforBLUE(int x, int y, bool[,] fieldBLUE, bool[,] fieldRED, bool[,] fieldGREEN)
        {
            int countRED = 0;
            int countGREEN = 0;
            int[] result = new int[] {0,0,0}; // SUM, RED, GREEN
            if (!fieldBLUE[x,y])
            {
                return result;
            }

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var hasEnemyRED = fieldRED[col, row];
                    var hasEnemyGREEN = fieldGREEN[col, row];
                    if (hasEnemyRED)
                            countRED++;
                    if (hasEnemyGREEN)
                          countGREEN++;
                }
            }
            result[0] = countRED + countGREEN;
            result[1] = countRED;
            result[2] = countGREEN;

            return result;
        }

        private int[] CountEnemyforRED(int x, int y, bool[,] fieldBLUE, bool[,] fieldRED, bool[,] fieldGREEN)
        {
            int countBLUE = 0;
            int countGREEN = 0;
            int[] result = new int[] { 0, 0, 0 }; // SUM, BLUE, GREEN
            if (!fieldRED[x, y])
            {
                return result;
            }

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var hasEnemyBLUE = fieldBLUE[col, row];
                    var hasEnemyGREEN = fieldGREEN[col, row];
                    if (hasEnemyBLUE)
                        countBLUE++;
                    if (hasEnemyGREEN)
                        countGREEN++;
                }
            }
            result[0] = countBLUE + countGREEN;
            result[1] = countBLUE;
            result[2] = countGREEN;

            return result;
        }

        private int[] CountEnemyforGREEN(int x, int y, bool[,] fieldBLUE, bool[,] fieldRED, bool[,] fieldGREEN)
        {
            int countBLUE = 0;
            int countRED = 0;
            int[] result = new int[] { 0, 0, 0 }; // SUM, BLUE, RED
            if (!fieldGREEN[x, y])
            {
                return result;
            }

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var hasEnemyBLUE = fieldBLUE[col, row];
                    var hasEnemyRED = fieldRED[col, row];
                    if (hasEnemyBLUE)
                        countBLUE++;
                    if (hasEnemyRED)
                        countRED++;
                }
            }
            result[0] = countBLUE + countRED;
            result[1] = countBLUE;
            result[2] = countRED;

            return result;
        }
    }
}
