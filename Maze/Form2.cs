using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form2 : Form
    {
        public int rowsNr = 0;
        public int columnsNr = 0;
        public int level;
        public int custom = -1; // custom = 1 and 0 for default
        internal Button[,] buttonMatrix = new Button[0,0];
        internal int startPositionX =0;
        internal int startPositionY=0;
        internal int finishPositionX=0;
        internal int finishPositionY=0;
        internal int[,] intMatrix;
        Algorithm algorithm = new Algorithm();
        GBFS gbfsAlgorithm = new GBFS();

        public Form2(int rows, int columns, int wantedLevel, int wantedCustom, int[,] matrix)
        {
            rowsNr = rows;
            columnsNr = columns;
            level = wantedLevel;
            custom = wantedCustom;
            intMatrix = matrix;

            InitializeComponent();
            createDynamicMaze();
            if(custom==0)
            ColorMatrixForDefault();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            messageLabel.ForeColor = Color.Black;
            messageLabel.BackColor = Color.PapayaWhip;
            
            if (custom == 0 || custom == 1)
            {
                bool validResult = ValidateInputButtonMatrix();
                if (validResult == false)
                {
                    messageLabel.Text = "You set more than one start or finish points";
                    messageLabel.BackColor = Color.Red;
                    messageLabel.ForeColor = Color.White;
                }
                else
                {
                    MoveRobot();
                }
                              
            }
            
        }

        public async void MoveRobot()
        {
            Stopwatch stopWatch = new Stopwatch();
                
            startPositionX = algorithm.FindElementXPosition(intMatrix, intMatrix.GetLength(0), intMatrix.GetLength(1), 0);
            startPositionY = algorithm.FindElementYPosition(intMatrix, intMatrix.GetLength(0), intMatrix.GetLength(1), 0);
            finishPositionX = algorithm.FindElementXPosition(intMatrix, intMatrix.GetLength(0), intMatrix.GetLength(1), 8);
            finishPositionY = algorithm.FindElementYPosition(intMatrix, intMatrix.GetLength(0), intMatrix.GetLength(1), 8);
            buttonMatrix[finishPositionX, finishPositionY].BackColor = Color.LightSeaGreen;
            stopWatch.Start();
            string path = algorithm.GetThePath(intMatrix, intMatrix.GetLength(1), intMatrix.GetLength(0), startPositionX, startPositionY, finishPositionX, finishPositionY);
            stopWatch.Stop();
            timeLabel.Text += "A* : " + stopWatch.ElapsedMilliseconds.ToString() + " milliseconds \nsteps = " + path.Length;

            Stopwatch gbfsStopWatch = new Stopwatch();
            gbfsStopWatch.Start();
            string gbfsPath = gbfsAlgorithm.BSFAlgorithm(intMatrix, intMatrix.GetLength(1), intMatrix.GetLength(0), startPositionX, startPositionY, finishPositionX, finishPositionY);
            gbfsStopWatch.Stop();
            var splitedGBFSpath = gbfsPath.ToCharArray();
            int nrOfSteps = splitedGBFSpath.Length;
            gbfsLabel.Text +=  "GBFS : " + gbfsStopWatch.ElapsedMilliseconds.ToString() + " milliseconds \nsteps = " + nrOfSteps;
            
            
            var splitedPath = path.ToCharArray();
            Bitmap bmp = new Bitmap(ResourcePictures.robot);
            buttonMatrix[startPositionX, startPositionY].BackColor = Color.Purple;
            buttonMatrix[startPositionX, startPositionY].Image = bmp;
            await Task.Delay(2000);
            buttonMatrix[startPositionX, startPositionY].Image = null;
            buttonMatrix[startPositionX, startPositionY].BackColor = Color.LightBlue;

            int currentXposition = startPositionX;
            int currentYposition = startPositionY;

            int solutionSecondsContor = 0;
            int valueProgressBar = 0;
            
            for (int i = 0; i < splitedPath.Length; i++)
            {
                valueProgressBar = (i + 1) * 100 / splitedPath.Length;
                channgeProgressBarValue(valueProgressBar);
                if (splitedPath[i].Equals('U'))
                {
                    if (buttonMatrix[currentXposition - 1, currentYposition].BackColor == Color.PapayaWhip)
                    {
                        buttonMatrix[currentXposition - 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 500 milliseconds on color white" ;
                        solutionSecondsContor += 500;
                        await Task.Delay(500);

                    }
                    if (buttonMatrix[currentXposition - 1, currentYposition].BackColor == Color.ForestGreen)
                    {
                        buttonMatrix[currentXposition - 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1300 milliseconds on color green";
                        solutionSecondsContor += 1300;
                        await Task.Delay(1300);
                    }
                    if (buttonMatrix[currentXposition - 1, currentYposition].BackColor == Color.DarkOrange)
                    {
                        buttonMatrix[currentXposition - 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1600 milliseconds on color orange";
                        solutionSecondsContor += 1600;
                       await Task.Delay(1600);
                    }
                    if (buttonMatrix[currentXposition - 1, currentYposition].BackColor == Color.Red)
                    {
                        buttonMatrix[currentXposition - 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1900 milliseconds on color red";
                        solutionSecondsContor += 1900;
                       await Task.Delay(1900);
                    }
                    if (buttonMatrix[currentXposition - 1, currentYposition].BackColor == Color.LightSeaGreen)
                    {
                        buttonMatrix[currentXposition - 1, currentYposition].Image = bmp;
                        messageLabel.Text = (float)solutionSecondsContor/ 1000 + " seconds in the end";
                        break;
                    }

                    buttonMatrix[currentXposition-1, currentYposition].Image = null;
                    buttonMatrix[currentXposition-1, currentYposition].BackColor = Color.LightBlue;
                    currentXposition--;
                }
                if (splitedPath[i].Equals('D'))
                {
                    if (buttonMatrix[currentXposition + 1, currentYposition].BackColor == Color.PapayaWhip)
                    {
                        buttonMatrix[currentXposition + 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 500 milliseconds on color white";
                        solutionSecondsContor += 500;
                       await Task.Delay(500);
                    }
                    if (buttonMatrix[currentXposition + 1, currentYposition].BackColor == Color.ForestGreen)
                    {
                        buttonMatrix[currentXposition + 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1300 milliseconds on color green";
                        solutionSecondsContor += 1300;
                       await Task.Delay(1300);
                    }
                    if (buttonMatrix[currentXposition + 1, currentYposition].BackColor == Color.DarkOrange)
                    {
                        buttonMatrix[currentXposition + 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1600 milliseconds on color orange";
                        solutionSecondsContor += 1600;
                       await Task.Delay(1600);
                    }
                    if (buttonMatrix[currentXposition + 1, currentYposition].BackColor == Color.Red)
                    {
                        buttonMatrix[currentXposition + 1, currentYposition].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1900 milliseconds on color red";
                        solutionSecondsContor += 1900;
                        await Task.Delay(1900);
                    }
                    if (buttonMatrix[currentXposition + 1, currentYposition].BackColor == Color.LightSeaGreen)
                    {
                        buttonMatrix[currentXposition + 1, currentYposition].Image = bmp;
                        messageLabel.Text = (float)solutionSecondsContor / 1000 + " seconds in the end";
                        break;
                    }

                    buttonMatrix[currentXposition+1, currentYposition].Image = null;
                    buttonMatrix[currentXposition+1, currentYposition].BackColor = Color.LightBlue;
                    currentXposition++;
                }
                if (splitedPath[i].Equals('R'))
                {
                    if (buttonMatrix[currentXposition, currentYposition + 1].BackColor == Color.PapayaWhip)
                    {
                        buttonMatrix[currentXposition, currentYposition + 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 500 milliseconds on color white";
                        solutionSecondsContor += 500;
                       await Task.Delay(500);
                    }
                    if (buttonMatrix[currentXposition, currentYposition + 1].BackColor == Color.ForestGreen)
                    {
                        buttonMatrix[currentXposition, currentYposition + 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1300 milliseconds on color green";
                        solutionSecondsContor += 1300;
                       await Task.Delay(1300);
                    }
                    if (buttonMatrix[currentXposition, currentYposition + 1].BackColor == Color.DarkOrange)
                    {
                        buttonMatrix[currentXposition, currentYposition + 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1600 milliseconds on color orange";
                        solutionSecondsContor += 1600;
                       await Task.Delay(1600);
                    }
                    if (buttonMatrix[currentXposition, currentYposition + 1].BackColor == Color.Red)
                    {
                        buttonMatrix[currentXposition, currentYposition + 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1900 milliseconds on color red";
                        solutionSecondsContor += 1900;
                       await Task.Delay(1900);
                    }
                    if (buttonMatrix[currentXposition, currentYposition + 1].BackColor == Color.LightSeaGreen)
                    {
                        buttonMatrix[currentXposition, currentYposition + 1].Image = bmp;
                        messageLabel.Text = (float)solutionSecondsContor / 1000 + " seconds in the end";
                        break;
                    }

                    buttonMatrix[currentXposition, currentYposition+1].Image = null;
                    buttonMatrix[currentXposition, currentYposition+1].BackColor = Color.LightBlue;
                    currentYposition++;
                }
                if (splitedPath[i].Equals('L'))
                {
                    if (buttonMatrix[currentXposition, currentYposition - 1].BackColor == Color.PapayaWhip)
                    {
                        buttonMatrix[currentXposition, currentYposition - 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 500 milliseconds on color white";
                        await Task.Delay(500);
                    }
                    if (buttonMatrix[currentXposition, currentYposition - 1].BackColor == Color.ForestGreen)
                    {
                        buttonMatrix[currentXposition, currentYposition - 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1300 milliseconds on color green";
                        await Task.Delay(1300);
                    }
                    if (buttonMatrix[currentXposition, currentYposition - 1].BackColor == Color.DarkOrange)
                    {
                        buttonMatrix[currentXposition, currentYposition - 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1600 milliseconds on color orange";
                        await Task.Delay(1600);
                    }
                    if (buttonMatrix[currentXposition, currentYposition - 1].BackColor == Color.Red)
                    {
                        buttonMatrix[currentXposition, currentYposition - 1].Image = bmp;
                        messageLabel.Text = solutionSecondsContor.ToString() + " + 1900 milliseconds on color red";
                        await Task.Delay(1900);
                    }
                    if (buttonMatrix[currentXposition, currentYposition - 1].BackColor == Color.LightSeaGreen)
                    {
                        buttonMatrix[currentXposition, currentYposition - 1].Image = bmp;
                        messageLabel.Text = (float)solutionSecondsContor / 1000 + " seconds in the end";
                        break;
                    }

                    buttonMatrix[currentXposition, currentYposition-1].Image = null;
                    buttonMatrix[currentXposition, currentYposition-1].BackColor = Color.LightBlue;
                    currentYposition--;
                }

            }
            
        }

        public void createDynamicMaze()
        {
            TableLayoutPanel mazeLayoutPanel = new TableLayoutPanel();
            mazeLayoutPanel.ColumnCount = columnsNr;
            mazeLayoutPanel.RowCount = rowsNr;
          
            mazeLayoutPanel.Dock = DockStyle.Fill;

            for (int x = 0; x < mazeLayoutPanel.RowCount; x++)
                mazeLayoutPanel.RowStyles.Add(new RowStyle() { Height = 100 / rowsNr, SizeType = SizeType.Percent });
            for (int x = 0; x < mazeLayoutPanel.ColumnCount; x++)
                mazeLayoutPanel.ColumnStyles.Add(new ColumnStyle() { Width = 100 / columnsNr, SizeType = SizeType.Percent });

            bigTableLayoutPanel.Controls.Add(mazeLayoutPanel);
            bigTableLayoutPanel.SetColumnSpan(mazeLayoutPanel, 5);

            mazeLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            buttonMatrix = new Button[rowsNr, columnsNr];
            for (int line = 1; line <= rowsNr; ++line)     
                for(int column = 1; column <= columnsNr; ++column )         
                {
                    Button newButton = new Button();
                    newButton.BackColor = Color.PapayaWhip;
                    newButton.Dock = DockStyle.Fill;
                    newButton.Click += new EventHandler(colourDynamicButton);
                    mazeLayoutPanel.Controls.Add(newButton);
                 
                    newButton.Name = "mazeButton" + line.ToString() + column.ToString();
                    buttonMatrix[line-1, column-1] = newButton;
                }            
            }
       
        private void restartButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LevelsForm levelsForm = new LevelsForm();
            Array.Clear(intMatrix, 0, intMatrix.Length);
            Array.Clear(buttonMatrix, 0, buttonMatrix.Length);
            rowsNr = 0;
            columnsNr = 0;
            levelsForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colourDynamicButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (level == 1)
            {
                if (button.BackColor == Color.PapayaWhip)
                {
                    button.BackColor = Color.Black;
                   
                }
                else
                {
                    if (button.BackColor == Color.Black)
                    {
                        button.BackColor = Color.Purple;
                        button.BackgroundImage = Properties.Resources.location;
                        button.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else
                    {
                        if (button.BackColor == Color.Purple)
                        {
                            button.BackColor = Color.LightSeaGreen;
                            button.BackgroundImage = Properties.Resources.finish;
                            button.BackgroundImageLayout = ImageLayout.Zoom;

                        }
                        else
                        {
                            if (button.BackColor == Color.LightSeaGreen)
                            {
                                button.BackColor = Color.PapayaWhip;
                                button.BackgroundImage = null;
                            }
                        }

                    }
                }
            }

            if (level == 2)
            {
                if (button.BackColor == Color.PapayaWhip)
                {
                    button.BackColor = Color.Black;
                }
                else
                {
                    if (button.BackColor == Color.Black)
                    {
                        button.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        if (button.BackColor == Color.ForestGreen)
                        {
                            button.BackColor = Color.DarkOrange;
                        }
                        else
                        {
                            if (button.BackColor == Color.DarkOrange)
                            {
                                button.BackColor = Color.Purple;
                                button.BackgroundImage = Properties.Resources.location;
                                button.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else
                            {
                                if (button.BackColor == Color.Purple)
                                {
                                    button.BackColor = Color.LightSeaGreen;
                                    button.BackgroundImage = Properties.Resources.finish;
                                    button.BackgroundImageLayout = ImageLayout.Zoom;

                                }
                                else
                                {
                                    if (button.BackColor == Color.LightSeaGreen)
                                    {
                                        button.BackColor = Color.PapayaWhip;
                                        button.BackgroundImage = null;
                                    }
                                }


                            }
                        }
                    }
                }
            }



            if (level == 3)
            {
                if (button.BackColor == Color.PapayaWhip)
                {
                    button.BackColor = Color.Black;
                }
                else
                {
                    if (button.BackColor == Color.Black)
                    {
                        button.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        if (button.BackColor == Color.ForestGreen)
                        {
                            button.BackColor = Color.DarkOrange;
                        }
                        else
                        {
                            if (button.BackColor == Color.DarkOrange)
                            {
                                button.BackColor = Color.Red;
                            }
                            else
                            {
                                if (button.BackColor == Color.Red)
                                {
                                    button.BackColor = Color.Purple;
                                    button.BackgroundImage = Properties.Resources.location;
                                    button.BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else
                                {
                                    if (button.BackColor == Color.Purple)
                                    {
                                        button.BackColor = Color.LightSeaGreen;
                                        button.BackgroundImage = Properties.Resources.finish;
                                        button.BackgroundImageLayout = ImageLayout.Zoom;

                                    }
                                    else
                                    {
                                        if (button.BackColor == Color.LightSeaGreen)
                                        {
                                            button.BackColor = Color.PapayaWhip;
                                            button.BackgroundImage = null;
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }

        }


        public bool ValidateInputButtonMatrix()
        {
            SetIntMatrixFomCustom();
            bool result = algorithm.validateInputMatrix(intMatrix, intMatrix.GetLength(1), intMatrix.GetLength(0));
            if (result)
                return true;
            else
            {
                Array.Clear(intMatrix, 0, intMatrix.Length);
                return false;
            }
        }

        public void SetIntMatrixFomCustom()
        {

            for (int i = 0; i < buttonMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < buttonMatrix.GetLength(1); j++)
                {
                    if (buttonMatrix[i, j].BackColor == Color.Black)
                    {
                        intMatrix[i, j] = 5;
                    }
                    if (buttonMatrix[i, j].BackColor == Color.PapayaWhip)
                    {
                        intMatrix[i, j] = 1;
                    }
                    if (buttonMatrix[i, j].BackColor == Color.ForestGreen)
                    {
                        intMatrix[i, j] = 2;
                    }
                    if (buttonMatrix[i, j].BackColor == Color.DarkOrange)
                    {
                        intMatrix[i, j] = 3;
                    }
                    if (buttonMatrix[i, j].BackColor == Color.Red)
                    {
                        intMatrix[i, j] = 4;
                    }
                    if (buttonMatrix[i, j].BackColor == Color.Purple)
                    {
                        intMatrix[i, j] = 0;
                    }
                    if (buttonMatrix[i, j].BackColor == Color.LightSeaGreen)
                    {
                        intMatrix[i, j] = 8;
                    }
                }
            }
        }

        public void ColorMatrixForDefault()
        {
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    if (intMatrix[i, j] == 1)
                    {
                        buttonMatrix[i, j].BackColor = Color.PapayaWhip;
                    }
                    if (intMatrix[i, j] == 2)
                    {
                        buttonMatrix[i, j].BackColor = Color.ForestGreen;
                    }
                    if (intMatrix[i, j] == 3)
                    {
                        buttonMatrix[i, j].BackColor = Color.DarkOrange;
                    }
                    if (intMatrix[i, j] == 4)
                    {
                        buttonMatrix[i, j].BackColor = Color.Red;
                    }
                    if (intMatrix[i, j] == 5)
                    {
                        buttonMatrix[i, j].BackColor = Color.Black;
                    }
                    if (intMatrix[i, j] == 0)
                    {
                        buttonMatrix[i, j].BackColor = Color.Purple;
                        buttonMatrix[i, j].BackgroundImage = Properties.Resources.location;
                        buttonMatrix[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    if (intMatrix[i, j] == 8)
                    {
                        buttonMatrix[i, j].BackColor = Color.LightSeaGreen;
                        buttonMatrix[i, j].BackgroundImage = Properties.Resources.finish;
                        buttonMatrix[i, j].BackgroundImageLayout = ImageLayout.Zoom;

                    }
                }
            }
        }

        public void channgeProgressBarValue (int newValue)
        {
            progressBar.Value = newValue;
        }
    }
}
