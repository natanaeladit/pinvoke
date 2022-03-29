using System;
using System.Runtime.InteropServices;

namespace PInvokeSamples
{
    public static class Program
    {
        [DllImport("libc.so.6")]
        private static extern int getpid();

        [DllImport(@"libhello", EntryPoint = "HelloFunc")]
        extern static void HelloFunc();

        [DllImport(@"libhello")]
        extern static int add(int a, int b);

        public static void Main(string[] args)
        {
            int pid = getpid();
            Console.WriteLine($"pid: {pid}");

            int t = add(2, 3);
            Console.WriteLine($"add: {t}");

            HelloFunc();
        }
    }
}