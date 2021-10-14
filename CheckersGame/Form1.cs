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
                    Color color = (i + j) % 2 == 0 ? Color.Red : Color.Black;
                    labelGrid[i, j].BackColor = color;

                    panel1.Controls.Add(labelGrid[i, j]);

                    labelGrid[i, j].Location = new Point(i * labelSize, j * labelSize);
                }
            }

            //Image blackPiece = Image.FromFile("C:/Users/user1/OneDrive/Documents/Fall 2021/Practicum in Software Development/Checkers/CheckersGame/blackPiece.jpg");
           

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (labelGrid[col, row].BackColor == Color.Black)
                    {
                        //labelGrid[col, row].Image = blackPiece;
                        labelGrid[col, row].Image = new Bitmap(Image.FromFile("C:/Users/user1/OneDrive/Documents/Fall 2021/Practicum in Software Development/whitePiece.jpg"), labelGrid[col, row].Size);
                    }
                }
            }
            for (int row =5; row <8; row++)
            {
                for (int col = 0; col <8; col++)
                {
                    if (labelGrid[col, row].BackColor == Color.Black) 
                    {
                        //labelGrid[col, row].Image = blackPiece;
                        labelGrid[col, row].Image = new Bitmap(Image.FromFile("C:/Users/user1/OneDrive/Documents/Fall 2021/Practicum in Software Development/redPiece.jpg"), labelGrid[col, row].Size);
                    }
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
    }
}
