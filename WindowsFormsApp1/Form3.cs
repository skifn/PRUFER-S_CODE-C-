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



    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


 
                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res1, res2, res3;
            int number = 4;
            int[] prufer = new int[number];

            prufer[0] = int.Parse(textBox1.Text);
            prufer[1] = int.Parse(textBox2.Text);
            prufer[2] = int.Parse(textBox3.Text);
            prufer[3] = int.Parse(textBox4.Text);
            int n = prufer.Length;
            int vertices = n + 2;
            int[] vertex_set = new int[vertices];


            StringBuilder sb = new StringBuilder("");



            // Инициализируем массив вершин
            for (int i = 0; i < vertices; i++)
                vertex_set[i] = 0;

            // Количество вхождений вершины в код
            for (int i = 0; i < vertices - 2; i++)
                vertex_set[prufer[i] - 1] += 1;

            Console.Write("\nThe edge is :\n");

            // Находим наименьшую метку, отсутствующую в
            // коде Прюфера[].


            int j = 0;
            for (int i = 0; i < vertices - 2; i++)
            {
                for (j = 0; j < vertices; j++)
                {
                    // Если j + 1 отсутствует 
                    if (vertex_set[j] == 0)
                    {
                        // Убираем из кода Прюфера и добавляем в 
                        vertex_set[j] = -1;
                        res1 = ($"( {(j + 1)}, {prufer[i]})");

                       

                        vertex_set[prufer[i] - 1]--;

                        sb.Append(res1);

                        label6.Text = sb.ToString();

                        break;
                    }
                }
            }

            j = 0;
            // Для последнего элемента
            for (int i = 0; i < vertices; i++)
            {
                if (vertex_set[i] == 0 && j == 0)
                {

                    res2 = ($"({(i + 1)},");

                    sb.Append(res2);
                    label6.Text = sb.ToString();
                    j++;
                }
                else if (vertex_set[i] == 0 && j == 1)
                {

                    res3 = ($"{(i + 1)})");

                    sb.Append(res3);
                    label6.Text = sb.ToString();
                }

            }


        }
    }





   


}
