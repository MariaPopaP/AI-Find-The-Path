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
    public partial class LevelsForm : Form
    {
        public TypeMazeForm typeMazeForm;
        public int level = 0;
     
        public LevelsForm()
        {
            InitializeComponent();
        }

        private void levelButton_Click(object sender, EventArgs e)
        {
            if( level1RadioButton.Checked == true ||  level2RadioButton.Checked == true || level3RadioButton.Checked == true)
            {
                if(level1RadioButton.Checked == true)
                {
                    level = 1;
                }

                if (level2RadioButton.Checked == true)
                {
                    level = 2;
                }

                if (level3RadioButton.Checked == true)
                {
                    level = 3;
                }

                this.Visible = false;
                typeMazeForm = new TypeMazeForm(level);               
                typeMazeForm.ShowDialog();

               
            }
            else
            {
                levelAttentionLabel1.Visible = true;
                levelAttentionLabel2.Visible = true;
                levelAttentionLabel3.Visible = true;

            }           
           
           
        }
    }
}
