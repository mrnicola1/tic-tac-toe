using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_and_O
{
    public partial class Form1 : Form
    {
        int leave = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                
                
                if (TL.Text =="")
                {
                    TL.Text = "X";
                }
                else
                {
                    TL.Text = "";

                }

               
            }
            
            if (textBox1.Text == "2")
            {
               
                if (TL.Text == "")
                {
                    TL.Text = "O";
                    
                }
                else
                {
                    TL.Text = "";
                 
                }

                
            }
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                
                if (button2.Text == "")
                {
                    button2.Text = "X";
                   
                }
                else
                {
                    button2.Text = "";
                }

                
            }


            if (textBox1.Text == "2")
            {
               
                if (button2.Text == "")
                {
                    button2.Text = "O";
                    
                }
                else
                {
                    button2.Text = "";
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (TR.Text == "")
                {
                    TR.Text = "X";
                }
                else
                {
                    TR.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (TR.Text == "")
                {
                    TR.Text = "O";

                }
                else
                {
                    TR.Text = "";

                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (ML.Text == "")
                {
                    ML.Text = "X";
                }
                else
                {
                    ML.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (ML.Text == "")
                {
                    ML.Text = "O";

                }
                else
                {
                    ML.Text = "";

                }


            }
        }

        private void MM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (MM.Text == "")
                {
                    MM.Text = "X";
                }
                else
                {
                    MM.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (MM.Text == "")
                {
                    MM.Text = "O";

                }
                else
                {
                    MM.Text = "";

                }


            }
        }

        private void MR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (MR.Text == "")
                {
                    MR.Text = "X";
                }
                else
                {
                    MR.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (MR.Text == "")
                {
                    MR.Text = "O";

                }
                else
                {
                    MR.Text = "";

                }


            }
        }

        private void BL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (BL.Text == "")
                {
                    BL.Text = "X";
                }
                else
                {
                    BL.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (BL.Text == "")
                {
                    BL.Text = "O";

                }
                else
                {
                    BL.Text = "";

                }


            }
        }

        private void BM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (BM.Text == "")
                {
                    BM.Text = "X";
                }
                else
                {
                    BM.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (BM.Text == "")
                {
                    BM.Text = "O";

                }
                else
                {
                    BM.Text = "";

                }


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {


                if (BR.Text == "")
                {
                    BR.Text = "X";
                }
                else
                {
                    BR.Text = "";

                }


            }

            if (textBox1.Text == "2")
            {

                if (BR.Text == "")
                {
                    BR.Text = "O";

                }
                else
                {
                    BR.Text = "";

                }


            }
        }
    }
}
