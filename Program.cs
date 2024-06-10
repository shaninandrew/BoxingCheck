using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Проверка работы с массивом через боксинг...");
        int size = 20000000;

        Stopwatch sw = new Stopwatch();
        sw.Reset();
        sw.Start();
        object[] obx = new object[size];
        Int128 sum = 0;
        for (int i = 0; i < size; i++)
        {
            obx[i] = (object) (i + 10);
            obx[i] = (object)((int) obx[i] * (3)+ (i > 0 ? (int)obx[i-1]:0));
            sum += (int)obx[i];
        }
        sw.Stop();
        Console.WriteLine($"В коробке-style = {((double)sw.Elapsed.TotalMilliseconds/1000).ToString("0.00")} сек");
        Console.WriteLine($"Сумма {sum} \r\n ");


        Console.WriteLine("Проверка работы с целочисленным массивом без боксинга...");
        sum = 0;
        sw.Reset();
        sw.Start();
        int[] int_x = new int[size];
        for (int i = 0; i < size; i++)
        {
            int_x[i] =(i + 10);
            int_x[i] = int_x[i]*3 + (i > 0 ? int_x[i - 1] : 0);
            sum = sum +  int_x[i];

        }
        sw.Stop();
        Console.WriteLine($"Без коробки-style = {((double)sw.Elapsed.TotalMilliseconds / 1000).ToString("0.00")} сек");
        Console.WriteLine($"Сумма {sum} ");

        Console.WriteLine("\r\n Проверка боксинга для строк...");
        sw.Reset();
        sw.Start();
        object[] str_x = new object[size];
        for (int i = 0; i < size; i++)
        {
            str_x[i] = " xx "+i.ToString("000000");
            str_x[i] = str_x[i]+"-" + (i > 0 ? int_x[i - 1] : 0).ToString();
        }
        sw.Stop();
        Console.WriteLine($"В коробке-style = {((double)sw.Elapsed.TotalMilliseconds / 1000).ToString("0.00")} сек \r\n");

        Console.WriteLine("\r\n Проверка работы без боксинга для строк...");
        
        sw.Reset();
        sw.Start();
        string[] str_p = new string[size];
        for (int i = 0; i < size; i++)
        {
            str_p[i] = " xx " + i.ToString("000000");
            str_p[i] = str_p[i] + "-" + (i > 0 ? int_x[i - 1]: 0).ToString();
        }
        sw.Stop();
        Console.WriteLine($"Вне коробки-style (чистые строки) = {((double)sw.Elapsed.TotalMilliseconds / 1000).ToString("0.00")} сек");
    }
}