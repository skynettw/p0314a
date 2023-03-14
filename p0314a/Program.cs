using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p0314a
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a, b;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a}+{b}=" + (a + b).ToString());
            
            */
            /*
            string resultMsg = "";
            int score = 0;

            Console.Write("Your score=");
            score = Convert.ToInt32(Console.ReadLine());

            
            if (score >= 60)
            {
                resultMsg = "Pass";
            } else
            {
                resultMsg = "Fail";
            }
            */

            /*

            resultMsg = (score >= 60) ? "Pass" : "Fail";

            Console.WriteLine("Your result is " + resultMsg);
            */
            // 0314作業要求如下：
            // 把下面這個程式改為 do/while迴圈，
            // 然後可以計算最大值、最小值、平均數、個數、標準差
            // 附上執行結果（20個數）的擷圖（.png or .jpg）
            // 把專案打包，加上上面的擷圖檔案全部壓縮成zip檔案上傳到教學平台
            int score=0, total=0;
            Console.Write("score=");
            score = Convert.ToInt32(Console.ReadLine());
            while (score>=0)
            {
               total += score;
               Console.Write("score=");
               score = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total = " + total.ToString());
            Console.ReadLine();
        }
    }
}
