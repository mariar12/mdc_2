using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
class Program
{
     static void Main(string[] args)
    {
        int i,j;
        double [,] m = new double [3,3]; //исходная матрица
        double[,] t = new double[3, 3]; //обратная матрица
        Random rnd = new Random();
        
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                m[i, j] = rnd.Next(4);
                Console.Write(" {0} ",m[i,j]);
            }
            Console.Write("\n");
        }
        Console.Write("------------\n");
            
        if (m[0, 0] == 0 || m[0, 0] != 0)
        {
            m[0, 0] = 1; 
            m[1, 1] = 2;
            m[2, 2] = 3;
                //1 круг
            t[0, 0] = 1;
            t[0, 1] = m[0, 1] * (-1);
            t[0, 2] = m[0, 2] * (-1);
            t[1, 1] = m[1, 1] * m[0, 0] - m[1, 0] * m[0, 1];
            t[1, 2] = m[1, 2] * m[0, 0] - m[1, 0] * m[0, 2];
            t[2, 1] = m[2, 1] * m[0, 0] - m[2, 0] * m[0, 1];
            t[2, 2] = m[2, 2] * m[0, 0] - m[2, 0] * m[0, 2];
            // деление каждого члена на t[0,0]
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    t[i, j] = t[i, j] / t[0, 0];
                }
            }
            //2 круг
            t[1, 1] = 1;
            t[1, 0] = t[1, 0] * (-1);
            t[1, 2] = t[1, 2] * (-1);
            t[0, 0] = t[0, 0] * t[1, 1] - t[0, 1] * t[1, 0];
            t[0, 2] = t[0, 2] * t[1, 1] - t[0, 1] * t[1, 2];
            t[2, 0] = t[2, 0] * t[1, 1] - t[2, 1] * t[1, 0];
            t[2, 2] = t[2, 2] * t[1, 1] - t[2, 1] * t[1, 2];
            // деление каждого члена на t[1,1]
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    t[i, j] = t[i, j] / t[1, 1];
                }
            }
            //круг 3
            t[2, 2] = 1;
            t[2, 0] = t[2, 0] * (-1);
            t[2, 1] = t[2, 1] * (-1);
            t[0, 0] = t[0, 0] * t[2, 2] - t[0, 2] * t[2, 0];
            t[0, 1] = t[0, 1] * t[2, 2] - t[0, 2] * t[2, 1];
            t[1, 0] = t[1, 0] * t[2, 2] - t[1, 2] * t[2, 0];
            t[1, 1] = t[1, 1] * t[2, 2] - t[1, 2] * t[2, 1];
            // деление каждого члена на t[2,2]
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    t[i, j] = t[i, j] / t[2, 2];
                    Console.Write(" {0} ", t[i,j]);
                }
                Console.Write("\n");
            }
        }
        Console.Read(); 
    }
}
