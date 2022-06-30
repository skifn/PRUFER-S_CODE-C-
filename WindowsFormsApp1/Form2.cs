using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, ver = 4, edg = 0, minimum = 0, p = 0;
            edg = ver - 1;
            string res1, res2;
            int[,] EDG = new int[edg, 2];
            int[] DG = new int[ver + 1];
            StringBuilder sb = new StringBuilder("");


            for (i = 0; i < edg; i++)
            {
              
                Console.WriteLine("V(1)");
                //EDG[i, 0] = int.Parse(textBox1.Text);

                //Console.WriteLine("V(2)");
                //EDG[i, 1] = int.Parse(textBox2.Text);

                //DG[EDG[i, 0]]++;
                //DG[EDG[i, 1]]++;
            }

            EDG[0, 0] = int.Parse(textBox1.Text);
            EDG[0, 1] = int.Parse(textBox2.Text);

            DG[EDG[0, 0]]++;
            DG[EDG[0, 1]]++;

            EDG[1, 0] = int.Parse(textBox5.Text);
            EDG[1, 1] = int.Parse(textBox4.Text);

            DG[EDG[1, 0]]++;
            DG[EDG[1, 1]]++;

            EDG[2, 0] = int.Parse(textBox2.Text);
            EDG[2, 1] = int.Parse(textBox3.Text);


            DG[EDG[2, 0]]++;
            DG[EDG[2, 1]]++;

          


            Console.WriteLine("Код Прюфера для дерева: ");
            for (i = 0; i < ver - 2; i++)
            {
                minimum = 10000;
                for (j = 0; j < edg; j++)
                {
                    if (DG[EDG[j, 0]] == 1)
                    {
                        if (minimum > EDG[j, 0])
                        {
                            minimum = EDG[j, 0];
                            p = j;
                        }
                    }
                    if (DG[EDG[j, 1]] == 1)
                    {
                        if (minimum > EDG[j, 1])
                        {
                            minimum = EDG[j, 1];
                            p = j;
                        }
                    }
                }
                DG[EDG[p, 0]]--; // удаляем вершину уменьшением ее степени до нуля
                DG[EDG[p, 1]]--; // уменьшим степень другой вершины

                if (DG[EDG[p, 0]] == 0)
                {
                    
                    res1 = ($"{EDG[p, 1]}");
                    sb.Append(res1);
                    label1.Text = sb.ToString();
                }

                else
                {
                    res2 = ($"{EDG[p, 0]}");
                    sb.Append(res2);
                    label1.Text = sb.ToString();
                }
            }
        }
    }
}
