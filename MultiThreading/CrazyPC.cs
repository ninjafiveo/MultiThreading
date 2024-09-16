using System;
using System.Threading;
using System.Windows.Forms;


namespace MultiThreading
{
    internal class CrazyPC
    {
        public static Random _random = new Random();
        public static void CrazyFunctionCall()
        {
            CrazyMouseThread();
        }

        static void CrazyMouseThread()
        {
            int moveX = 0;
            int moveY = 0;

            while (true)
            {
                moveX = _random.Next(40)-20;
                Console.WriteLine(moveX);
                moveY = _random.Next(40)-20;
                Console.WriteLine(moveY);
                // Need System.Drawing reference for Drawing Mouse
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(100);
            }

        }


    }
}
