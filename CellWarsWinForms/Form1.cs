using CellsGame;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CellWarsWinForms
{
    public partial class WindowForm : Form
    {
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngineBLUE;
        private GameEngine gameEngineRED;
        private GameEngine gameEngineGREEN;
        private WarEngine warEngine;
        private int countOfBLUE;
        private int countOfRED;
        private int countOfGREEN;
        

        public WindowForm()
        {
            InitializeComponent();
        }

        //Таймер Тик
        private void timer1_Tick(object sender, EventArgs e)
        {
            PrintNextGen();
        }

        //Действия при нажатии на кнопки Start и Stop
        private void bStart_Click(object sender, EventArgs e)
        {
            bStart.Enabled = false;
            bStop.Enabled = true;
            tbDensityBLUE.Enabled = false;
            tbDensityRED.Enabled = false;
            tbDensityGREEN.Enabled = false;
            tbResolution.Enabled = false;

            StartGame();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            bStart.Enabled = true;
            bStop.Enabled = false;
            tbDensityBLUE.Enabled = true;
            tbDensityRED.Enabled = true;
            tbDensityGREEN.Enabled = true;
            tbResolution.Enabled = true;
            timer1.Stop();
        }

        //Первоначальные настройки при старте
        private void StartGame()
        {
            if (timer1.Enabled)
                return;
            
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            resolution = tbResolution.Value;

            gameEngineBLUE = new GameEngine
                (
                    rows: pictureBox.Height / resolution,
                    cols: pictureBox.Width / resolution,
                    density: tbDensityBLUE.Minimum + tbDensityBLUE.Maximum - tbDensityBLUE.Value
                );

            gameEngineRED = new GameEngine
                (
                    rows: pictureBox.Height / resolution,
                    cols: pictureBox.Width / resolution,
                    density: tbDensityRED.Minimum + tbDensityRED.Maximum - tbDensityRED.Value
                );

            //При равных плотностях населения клеток происходит взаимное их уничтожениие. Поэтому меняем плотность зелёных
            int DensityGREEN = tbDensityGREEN.Value;
            if (tbDensityBLUE.Value == tbDensityRED.Value && tbDensityBLUE.Value == tbDensityGREEN.Value && tbDensityGREEN.Value > 2)
            {
                DensityGREEN -= 1;
            }
            else if (tbDensityBLUE.Value == tbDensityRED.Value && tbDensityBLUE.Value == tbDensityGREEN.Value && tbDensityGREEN.Value == 2)
            {
                DensityGREEN += 1;
            }

            gameEngineGREEN = new GameEngine
                (
                    rows: pictureBox.Height / resolution,
                    cols: pictureBox.Width / resolution,
                    density: tbDensityGREEN.Minimum + tbDensityGREEN.Maximum - DensityGREEN
                );

            warEngine = new WarEngine
                (
                    rows: pictureBox.Height / resolution,
                    cols: pictureBox.Width / resolution
                );
            
            Text = $"Generation {gameEngineBLUE.currientGen}";

            graphics = Graphics.FromImage(pictureBox.Image);

            timer1.Start();
        }

        //Основной метод для связи с движками и отрисовки
        private void PrintNextGen()
        {
            graphics.Clear(Color.Black);

            //Получение текущих поколений
            var fieldBLUE = gameEngineBLUE.GetCurrentGen();

            var fieldRED = gameEngineRED.GetCurrentGen();

            var fieldGREEN = gameEngineGREEN.GetCurrentGen();

            //Война
            warEngine.War(fieldBLUE, fieldRED, fieldGREEN);

            //Получение поколений после войны
            fieldBLUE = warEngine.GetAfterWarFieldBLUE();
            fieldRED = warEngine.GetAfterWarFieldRED();
            fieldGREEN = warEngine.GetAfterWarFieldGREEN();

            //Переменные для отрисовки поля
            int cols = fieldBLUE.GetLength(0);
            int rows = fieldBLUE.GetLength(1);

            //Отрисовка
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (fieldBLUE[x, y])
                    {
                        graphics.FillRectangle(Brushes.DeepSkyBlue, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        countOfBLUE++;
                    }

                    if (fieldRED[x, y])
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        countOfRED++;
                    }

                    if (fieldGREEN[x,y])
                    {
                        graphics.FillRectangle(Brushes.Green, x * resolution, y * resolution, resolution - 1, resolution - 1);
                        countOfGREEN++;
                    }
                }
            }

            pictureBox.Refresh();
            
            //Изменения в UI
            Text = $"Generation {gameEngineBLUE.currientGen}";
            tBlueCount.Text = $"Count of Blue: {countOfBLUE}";
            tRedCount.Text = $"Count of Red: {countOfRED}";
            tGreenCount.Text = $"Count of Green: {countOfGREEN}";

            //Сброс счетчиков
            countOfBLUE = 0;
            countOfRED = 0;
            countOfGREEN = 0;

            //Просчет следующих поколений
            gameEngineBLUE.NextGenAfterWar(fieldBLUE);
            gameEngineRED.NextGenAfterWar(fieldRED);
            gameEngineGREEN.NextGenAfterWar(fieldGREEN);
        }

        //Отображение изменений настроек в UI
        private void tbResolution_ValueChanged(object sender, EventArgs e)
        {
            tResolution.Text = $"Resolution: {tbResolution.Value}";
        }

        private void tbDensityBLUE_ValueChanged(object sender, EventArgs e)
        {
            tDensityBlue.Text = $"Density Blue: {tbDensityBLUE.Value}";
        }

        private void tbDensityRED_ValueChanged(object sender, EventArgs e)
        {
            tDensityRed.Text = $"Density Red: {tbDensityRED.Value}";
        }

        private void tbDensityGREEN_ValueChanged(object sender, EventArgs e)
        {
            tDensityGreen.Text = $"Density Green: {tbDensityGREEN.Value}";
        }

        private void tbBlueRedGreen_ValueChanged(object sender, EventArgs e)
        {
            if (tbBlueRedGreen.Value == 1)
            {
                tBLUE.Enabled = true;
                tRED.Enabled = false;
                tGREEN.Enabled = false;
            }
            else if (tbBlueRedGreen.Value == 2)
            {
                tRED.Enabled = true;
                tBLUE.Enabled = false;
                tGREEN.Enabled = false;
            }
            else
            {
                tGREEN.Enabled = true;
                tBLUE.Enabled = false;
                tRED.Enabled = false;
            }
        }

        //Добавление и удаление клеток мышкой
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if (tbBlueRedGreen.Value == 1)
            {
                if (e.Button == MouseButtons.Left)
                {

                    var point = e.Location;

                    var x = point.X / resolution;
                    var y = point.Y / resolution;
                    gameEngineBLUE.AddCell(x, y);
                }

                if (e.Button == MouseButtons.Right)
                {

                    var point = e.Location;

                    var x = point.X / resolution;
                    var y = point.Y / resolution;
                    gameEngineBLUE.RemoveCell(x, y);
                }
            }
            else if (tbBlueRedGreen.Value == 2)
            {
                if (e.Button == MouseButtons.Left)
                {

                    var point = e.Location;

                    var x = point.X / resolution;
                    var y = point.Y / resolution;
                    gameEngineRED.AddCell(x, y);
                }

                if (e.Button == MouseButtons.Right)
                {

                    var point = e.Location;

                    var x = point.X / resolution;
                    var y = point.Y / resolution;
                    gameEngineRED.RemoveCell(x, y);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {

                    var point = e.Location;

                    var x = point.X / resolution;
                    var y = point.Y / resolution;
                    gameEngineGREEN.AddCell(x, y);
                }

                if (e.Button == MouseButtons.Right)
                {

                    var point = e.Location;

                    var x = point.X / resolution;
                    var y = point.Y / resolution;
                    gameEngineGREEN.RemoveCell(x, y);
                }
            }
        }

        
    }
}
