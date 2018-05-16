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
    public partial class DimensionsForm : Form
    {
        private Form2 mazeForm;
        public int rowNumber = 0;
        public int columnNumber = 0;
        public int wantedLevel = 0;

        public DimensionsForm(int chosenLevel)
        {
            wantedLevel = chosenLevel;

            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            attentionColumnLabel.Visible = false;
            attentionRowLabel.Visible = false;

            bool okRows = int.TryParse(rowsNumberTextBox.Text, out rowNumber);
            bool okColumns = int.TryParse(columnsNumberTextBox.Text, out columnNumber);
           
            if( !okColumns || columnNumber > 100)
            { 
                attentionColumnLabel.Visible = true;                     
            }

            if( !okRows || rowNumber > 100)
            {
                attentionRowLabel.Visible = true;
            }     
          
            if( attentionColumnLabel.Visible == false && attentionRowLabel.Visible == false )
            {
                this.Visible = false;
                int[,] intMatrix = new int[rowNumber, columnNumber];
                mazeForm = new Form2(rowNumber, columnNumber, wantedLevel, 1, intMatrix);
                mazeForm.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
