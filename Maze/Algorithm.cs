using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Algorithm
    {

        public bool TestElementInQueue(Queue<int[,]> coada, int[,] matrix, int columns, int rows)
        {
            foreach (int[,] element in coada)
            {
                int k = 0;
                for (int i = 0; i < rows && k == 0; i++)
                    for (int j = 0; j < columns && k == 0; j++)
                        if (matrix[i, j] != element[i, j])
                            k = 1;
                if (k == 0)
                    return true;
            }
            return false;
        }

        /*
         * the F funtion for the A* algorithm. 
         * */
        public int GetF(int[,] matrix, int x, int y, int xfinal, int yfinal)
        {
            return Math.Abs(x - xfinal) + Math.Abs(y - yfinal);
        }

        public int FindTheCurrentElementXPosition(int[,] matrix, int columns, int rows)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (matrix[i, j] == 0)
                        return i;
            return 0;

        }
        /*
         * Finds the position of the current element, the current element is marked as 0 in the current matrix
         * */
        public int FindTheCurrentElementYPosition(int[,] matrix, int columns, int rows)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (matrix[i, j] == 0)
                        return j;
            return 0;

        }

        public int FindElementXPosition(int[,] matrix, int rows, int columns, int wantedElement)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (matrix[i, j] == wantedElement)
                        return i;
            return 0;

        }

        public int FindElementYPosition(int[,] matrix, int rows, int columns, int wantedElement)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (matrix[i, j] == wantedElement)
                        return j;
            return 0;

        }


        /*
         * The A* Algorithm, 
         * The result is a string like U - up, D-down, R-right, L-left, like the robot should move until he finds the the finish Point
         * **/
        public String GetThePath(int[,] input, int columns, int rows, int xstart, int ystart, int xfinish, int yfinish)
        {
            ///the curent position is marked with 0 in the g funtion
            List<Tuple<int[,], int, int, string>> list = new List<Tuple<int[,], int, int, string>>();
            // Tuple - matrix, value for F function, value for G funtion 

            list.Add(new Tuple<int[,], int, int, string>(input, GetF(input, xstart, ystart, xfinish, yfinish), 0, ""));

            Queue<int[,]> coada = new Queue<int[,]>();

            coada.Enqueue(input);

            while (list.Count() > 0)
            {

                list.Sort((a, b) =>
                {

                    if (a.Item2 == b.Item2)
                        return a.Item3.CompareTo(b.Item3);
                    else
                        return a.Item2.CompareTo(b.Item2);

                });

                int x = FindTheCurrentElementXPosition(list[0].Item1, columns, rows);
                int y = FindTheCurrentElementYPosition(list[0].Item1, columns, rows);

                //sus
                if (x - 1 >= 0)
                {
                    if (list[0].Item1[x - 1, y] != 5 && list[0].Item1[x - 1, y] != -1)
                    {
                        int[,] currentMatrix = (int[,])list[0].Item1.Clone();
                        currentMatrix[x, y] = -1;
                        int valueCell = currentMatrix[x - 1, y] + list[0].Item3;
                        currentMatrix[x - 1, y] = 0;
                        if (TestElementInQueue(coada, currentMatrix, columns, rows) == false)
                        {
                            coada.Enqueue(currentMatrix);
                            string path = list[0].Item4.Insert(list[0].Item4.Length, "U");
                            list.Add(new Tuple<int[,], int, int, string>(currentMatrix, GetF(currentMatrix, x - 1, y, xfinish, yfinish) + valueCell, valueCell, path));
                            if (x - 1 == xfinish && y == yfinish)
                            {
                                return path;

                            }

                        }

                    }

                }

                //jos
                if (x + 1 < rows)
                {
                    if (list[0].Item1[x + 1, y] != 5 && list[0].Item1[x + 1, y] != -1)
                    {
                        int[,] currentMatrix = (int[,])list[0].Item1.Clone();
                        currentMatrix[x, y] = -1;
                        int valueCell = currentMatrix[x + 1, y] + list[0].Item3;
                        currentMatrix[x + 1, y] = 0;
                        if (TestElementInQueue(coada, currentMatrix, columns, rows) == false)
                        {
                            coada.Enqueue(currentMatrix);
                            string path = list[0].Item4.Insert(list[0].Item4.Length, "D");
                            list.Add(new Tuple<int[,], int, int, string>(currentMatrix, GetF(currentMatrix, x + 1, y, xfinish, yfinish) + valueCell, valueCell, path));
                            if (x + 1 == xfinish && y == yfinish)
                            {
                                return path;

                            }
                        }
                    }
                }

                //stanga
                if (y - 1 >= 0)
                {
                    if (list[0].Item1[x, y - 1] != 5 && list[0].Item1[x, y - 1] != -1)
                    {
                        int[,] currentMatrix = (int[,])list[0].Item1.Clone();
                        currentMatrix[x, y] = -1;
                        int valueCell = currentMatrix[x, y - 1] + list[0].Item3;
                        currentMatrix[x, y - 1] = 0;
                        if (TestElementInQueue(coada, currentMatrix, columns, rows) == false)
                        {
                            coada.Enqueue(currentMatrix);
                            string path = list[0].Item4.Insert(list[0].Item4.Length, "L");
                            list.Add(new Tuple<int[,], int, int, string>(currentMatrix, GetF(currentMatrix, x, y - 1, xfinish, yfinish) + valueCell, valueCell, path));
                            if (x == xfinish && y - 1 == yfinish)
                            {
                                return path;
                            }
                        }
                    }
                }
                // dreapta
                if (y + 1 < columns)
                {
                    if (list[0].Item1[x, y + 1] != 5 && list[0].Item1[x, y + 1] != -1)
                    {
                        int[,] currentMatrix = (int[,])list[0].Item1.Clone();
                        currentMatrix[x, y] = -1;
                        int valueCell = currentMatrix[x, y + 1] + list[0].Item3;
                        currentMatrix[x, y + 1] = 0;
                        if (TestElementInQueue(coada, currentMatrix, columns, rows) == false)
                        {
                            coada.Enqueue(currentMatrix);
                            string path = list[0].Item4.Insert(list[0].Item4.Length, "R");
                            list.Add(new Tuple<int[,], int, int, string>(currentMatrix, GetF(currentMatrix, x, y + 1, xfinish, yfinish) + valueCell, valueCell, path));
                            if (x == xfinish && y + 1 == yfinish)
                            {
                                return path;

                            }
                        }
                    }
                }
                list.RemoveAt(0);
            }
            return "";
        }


        public bool validateInputMatrix(int[,] input, int columns, int rows)
        {
            int startContor = 0;
            int finishContor = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (input[i, j] == 0)
                    {
                        startContor++;
                        if (startContor > 1)
                        {
                            return false;
                        }
                            
                    }
                    else
                    {
                        if (input[i, j] == 8)
                        {
                            finishContor++;
                        }
                            
                        if (finishContor > 1)
                        {
                            return false;
                        }
                            
                    }
                }
                   
            }
            if (startContor == 1 && finishContor == 1)
                return true;
            else
                return false;
        }
    }
}
