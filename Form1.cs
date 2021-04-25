using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count_p1 = 0, count_p2=0, count_tie=0 ;

            Random rd = new Random();
            /*      for rd:
             *      0  means SCISSORS 
             *      1  means PAPER 
             *      2  means ROCK 
             */
            int rand_num;
            for (int i =0; i < 100; i++)
            {
                

                rand_num = rd.Next(0, 3);
                if (rand_num == 0 )
                {
                    count_p2++;
                }
                if (rand_num == 1)
                {
                    count_tie++;
                }
                if (rand_num == 2)
                {
                    count_p1++;
                }
               
                
            }

            richTextBox2.Text = "The Player A win "+ count_p1.ToString()+ " of 100 Game\n\nThe olayer B win " + count_p2.ToString() + " of 100 Game\n\nTie: " + count_tie.ToString()+" of 100 Game";
            count_p1 = 0;
            count_p2 = 0; 
            count_tie = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
        }
    }
}
