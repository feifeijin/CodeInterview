﻿using System;
namespace CodeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试开始");
            Chapter1_1();
        }

        private static void Chapter1_1()
        {
            while (true)
            {

                Console.WriteLine("请输入校验字符串，输入 exit 退出。");
                string str = Console.ReadLine();
                if(str.Equals("exit"))break;
                Chapter1.Chapter1.isUniqueChar(str);
            }

        }
    }
}
