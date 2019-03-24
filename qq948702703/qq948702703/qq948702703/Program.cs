using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qq948702703
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(inputs[0]);
            jisuan a = new jisuan(n);
            a.System();
            Console.ReadKey();
        }
    }
}
public class jisuan
{ int n;
   public jisuan(int n)
    {
        this.n = n;
    }
    public void System()
    {
        
        Random random = new Random();
        for(int i=0;i<n; i++)
        {
            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);
            int num3 = random.Next(1, 100);
            int sum = 0;
            int num4= random.Next(0, 5);
            switch(num4)
            {
                case 1:
                    sum = num1 + num2;
                    Console.WriteLine(num1+"+"+num2+"=" + sum);
                    break;
                case 2:
                    sum = num1 - num2;
                    Console.WriteLine(num1 + "-" + num2 + "=" + sum);
                    break;
                case 3:
                    sum = num1 * num2;
                    Console.WriteLine(num1 + "*" + num2 + "=" + sum);
                    break;
                case 4:
                    if (num1 % num2 == 0)
                    {
                        sum = num1 / num2;
                        Console.WriteLine(num1 + "/" + num2 + "=" + sum);
                    }
                    else
                    {
                        sum = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + "=" + sum);
                    }
                    break;
            }
          
        }
    }
 
}
