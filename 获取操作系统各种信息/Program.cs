using System;
using System.Runtime.InteropServices;

namespace 获取操作系统各种信息
{
    class Program
    {
        static void Main(string[] args)
        {
			//判断是否为操作系统
			Console.WriteLine("判断是否为Windows Linux OSX");
			Console.WriteLine($"Linux:{RuntimeInformation.IsOSPlatform(OSPlatform.Linux)}");
			Console.WriteLine($"OSX:{RuntimeInformation.IsOSPlatform(OSPlatform.OSX)}");
			Console.WriteLine($"Windows:{RuntimeInformation.IsOSPlatform(OSPlatform.Windows)}");
			//获取操作系统架构、名称
			Console.WriteLine($"系统架构：{RuntimeInformation.OSArchitecture}");
			Console.WriteLine($"系统名称：{RuntimeInformation.OSDescription}");
			Console.WriteLine($"进程架构：{RuntimeInformation.ProcessArchitecture}");
			Console.WriteLine($"是否64位操作系统：{Environment.Is64BitOperatingSystem}");
			Console.ReadKey();
        }
    }
}
