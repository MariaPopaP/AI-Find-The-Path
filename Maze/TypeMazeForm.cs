using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class TypeMazeForm : Form
    {
        public int level = 0;
        public DimensionsForm dimensionsForm;
        public Form2 mazeForm;


        public TypeMazeForm(int chosenLevel)
        {
            level = chosenLevel;
            InitializeComponent();
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {


            this.Visible = false;
            if (level == 1)
            {
                int[,] matrix = GetMatrixForDefault(level);
                mazeForm = new Form2(matrix.GetLength(0), matrix.GetLength(1), level, 0, matrix);
                mazeForm.ShowDialog();
            }

            if (level == 2)
            {
                int[,] matrix = GetMatrixForDefault(level);
                mazeForm = new Form2(matrix.GetLength(0), matrix.GetLength(1), level, 0, matrix);
                mazeForm.ShowDialog();
            }

            if (level == 3)
            {
                int[,] matrix = GetMatrixForDefault(level);
                mazeForm = new Form2(matrix.GetLength(0), matrix.GetLength(1), level, 0, matrix);
                mazeForm.ShowDialog();
            }
        }

        public int[,] GetMatrixForDefault(int level)
        {
            int[,] matrix = new int[0, 0];
            if (level == 1)
            {
                matrix = new int[8, 5] { { 0, 1, 1, 1, 1 }, { 1, 1, 1, 5, 1 }, { 5, 5, 1, 5, 1 }, { 1, 1, 1, 5, 1 }, { 1, 5, 1, 5, 1 }, { 1, 5, 1, 1, 1 }, { 1, 5, 1, 5, 1 }, { 8, 1, 1, 1, 1 } };
            }
            if (level == 2)
            {
             matrix = new int[5, 5] { { 0, 1, 2, 3, 5 }, { 1, 5, 5, 5, 5 }, { 2, 2, 3, 1, 1 }, { 3, 5, 5, 5, 8 }, { 3, 3, 3, 3, 3 } };
            }
                
            if (level == 3)
            {
                matrix = new int[9, 9] { { 5, 8, 2, 2, 2, 2, 1, 3, 1}, { 1, 1, 2, 2, 5, 3, 1, 1,1 }, { 1, 1, 2, 5, 1, 1, 2, 3, 1 }, { 1, 5, 4, 5, 3, 2, 1, 1, 1 },
                                          {5, 3, 2, 1, 1, 3, 4, 1, 1}, { 1, 1, 1, 2, 5, 4, 2, 5, 1}, {1, 2, 2, 3, 5, 2, 5, 2, 2 }, { 2, 1, 4, 5, 1, 1, 2, 1, 1 },
                                          {3, 1, 0, 1, 4, 5, 2, 2, 3}};
            }
            return matrix;
        }



        private void customButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dimensionsForm = new DimensionsForm(level);
            dimensionsForm.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LevelsForm levelsForm = new LevelsForm();
            levelsForm.ShowDialog();
        }
    }
}
