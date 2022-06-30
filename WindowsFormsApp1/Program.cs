using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }




    class PRUFER
    {


        public int vertices;
        public int[] vertex_set;
        public int i = 0, j = 0, ver = 0, edg = 0, minimum = 0, p = 0;

        public void printTreeEdges(int[] prufer, int m)
        {
            vertices = m + 2;
            vertex_set = new int[vertices];

            // Инициализируем массив вершин
            for (int i = 0; i < vertices; i++)
                vertex_set[i] = 0;

            // Количество вхождений вершины в код
            for (int i = 0; i < vertices - 2; i++)
                vertex_set[prufer[i] - 1] += 1;

            Console.Write("Дерево:\n");

            // Находим наименьшую вершину, отсутствующую в
            // коде Прюфера[]
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
                        Console.Write("(" + (j + 1) + ", "
                                      + prufer[i] + ") ");

                        vertex_set[prufer[i] - 1]--;

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
                    Console.Write("(" + (i + 1) + ", ");
                    j++;
                }
                else if (vertex_set[i] == 0 && j == 1)
                    Console.Write((i + 1) + ")\n");
            }

        }
        public void coding()
        {
            Console.WriteLine("Количество вершин в графе = 4");
            ver = 4;
            Console.WriteLine("\n");
            edg = ver - 1;



            int[,] EDG = new int[edg, 2];
            int[] DG = new int[ver + 1];


            Console.WriteLine($"Это дерево имеет {edg} рёбер и {ver} вершин");
            Console.WriteLine($"Существует {edg} пар вершин в дереве");



            for (i = 0; i < edg; i++)
            {
                Console.WriteLine($"Введите соединение ребра {i + 1}");
                Console.WriteLine("V(1):");
                EDG[i, 0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" V(2) :");
                EDG[i, 1] = Convert.ToInt32(Console.ReadLine());

                DG[EDG[i, 0]]++;
                DG[EDG[i, 1]]++;
            }


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
                    Console.WriteLine($"{EDG[p, 1]}");
                else
                    Console.WriteLine($"{EDG[p, 0]}");
            }

        }

    }

    class Vertex
    {
        public int  vertices;

        Vertex() { }

        ~Vertex() { }
    }


    class Edge
    {

        public int v1, v2;

        Edge() { }

        ~Edge() { }
    }


}

