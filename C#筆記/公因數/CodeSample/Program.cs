using System;

// 輸入整數,列出所有公因數

namespace CodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCommonFactor();
            //ReverseInteger();
            SwitchNoBreak();
        }

        //利用Switch結合多次同類型判斷
        static void SwitchNoBreak()
        {
            int age;
            Console.WriteLine("Enter the Age: ");
            age = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            if (age >=18)
            {
                sb.Append("限制級");
            }
            if(age >= 13)
            {
                if (sb.Length > 0)
                {
                   sb.Append("、"); 
                }
                sb.Append("輔導級");
            }
            if (age >= 6)
            {
                if (sb.Length > 0)
                {
                   sb.Append("、"); 
                }
                sb.Append("保護級");
            }
            if (sb.Length > 0)
            {
                sb.Append("及"); 
            }
            sb.Append("一般級電影");

            Console.WriteLine("可以看" + sb.ToString());
        }

        //輸入整數,反向列印,例:輸入123,印出321
        static void ReverseInteger()
        {
            int num , reverse=0;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());
            //=================================
            string strNum = num.ToString();
            string strReverse = "";
            for (int i = strNum.Length - 1; i >= 0; i--)
            {
                Console.Write(strNum[i]);
                strReverse = strReverse + strNum[i];
            }
            Console.WriteLine();
            reverse = int.Parse(strReverse);
            //=================================
            Console.WriteLine("Reverse of Entered Number is :" + reverse);
            Console.ReadLine();
        }

        //列出所有公因數
        static void GetCommonFactor()
        {
            int m;
            Console.WriteLine("Enter a Number:");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < m; i++)
            {
                if (m % i == 0)
                {   
                    string output = i + " is the factor of " + m;
                    Console.WriteLine(output);
                }
            }
            Console.ReadLine();
        }
    }
}
