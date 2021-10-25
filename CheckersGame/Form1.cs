using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class Form1 : Form
    {
        public static Label[,] labelGrid = new Label[8, 8];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
            comboBox1.SelectedIndex = 0;
        }

        private void populateGrid()
        {
            int labelSize = panel1.Width / 8;
            panel1.Height = panel1.Width;

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    labelGrid[i, j] = new Label();
                    labelGrid[i, j].Height = labelSize;
                    labelGrid[i, j].Width = labelSize;
                    labelGrid[i, j].Click += labelGridClick;
                    Color color = (i + j) % 2 == 0 ? Color.Tan : Color.Black;
                    labelGrid[i, j].BackColor = color;

                    panel1.Controls.Add(labelGrid[i, j]);

                    labelGrid[i, j].Location = new Point(i * labelSize, j * labelSize);
                }
            }
           

           

        }

        static void labelGridClick(object sender, EventArgs e)
        {
            int col = 0;
            int row = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Label clickedLabel = (Label)sender;
                    if (clickedLabel.Equals(labelGrid[i, j]))
                    {
                        col = i;
                        row = j;
                    }
                }
            }
            MessageBox.Show("(" + row + ", " + col + ")");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           if (whiteButton.Checked)
            {
                setComputer(redPiece.Image);
                setPlayer(whitePiece.Image);
            }
            else
            {
                setComputer(whitePiece.Image);
                setPlayer(redPiece.Image);
            }
        }

        public void setComputer(Image userPiece)
        {
            // set top, computer
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (labelGrid[col, row].BackColor == Color.Black)
                    {
                        labelGrid[col, row].Image = new Bitmap(userPiece, labelGrid[col, row].Size);

                    }
                }
            }
        }

        public void setPlayer(Image compPiece)
        {
            //set bottom, player
            for (int row = 5; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (labelGrid[col, row].BackColor == Color.Black)
                    {
                        labelGrid[col, row].Image = new Bitmap(compPiece, labelGrid[col, row].Size);
                    }
                }
            }
        }

    }
}
