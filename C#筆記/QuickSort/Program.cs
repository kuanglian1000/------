using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] d = new Int32[] {10,0,6,19,8,34,1};
            ReadData(d);
            Run(d,0,d.Length);
            ReadData(d);
        }

        static void ReadData(int[] data)
        {
          for (int i = 0; i < data.Length; i++)
          {
            Console.Write(Convert.ToString(data[i]));
            if (i<data.Length-1)
            {
                Console.Write("|");
            }else
            {
                Console.WriteLine();
            }
          }
        }

        static void Run(int[] data , int low , int high)
        {
            int middle = data[(low + high) / 2];
            int i = low;
            int h = high;

            do
            {
              //掃描左側序列
              while (data[i] < middle && i < high)
              {
                i++;
              }
              //掃描右側序列
              while (data[h] > middle && h > low)
              {
                h--;
              }
              if (i<=h)
              {
                  int temp = data[i];
                  data[i] = data[h];
                  data[h] = temp;
                  i++;
                  h--;
              }
            } while (i<=h);
            if (h > low)
            {
              Run(data,low,h);
            }
            if (i < high)
            {
              Run(data,i,high);
            }
        }
    }
}
