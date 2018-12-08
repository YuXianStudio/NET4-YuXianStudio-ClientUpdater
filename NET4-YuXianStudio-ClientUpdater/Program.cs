using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace NET4_YuXianStudio_ClientUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            string version = ".minecraft/versions/3.1.3.clientversion";//判断客户端版本
            if (File.Exists(version))
            {
                Console.WriteLine("");
                Console.WriteLine("Copyright © 2019 YuxianStudio. All Rights Reserved. 使用有问题请联系:yuxianstudio@gmail.com");
                Console.WriteLine("");
                Console.WriteLine("非常重要：请确保该程序在根目录下!!!");
                Console.WriteLine("");
                Console.WriteLine("检测到客户端已经是最新版本，无需更新");
                Console.WriteLine("");
                Console.WriteLine("若客户端无法启动，请前往官网 https://mc.yuxianstudio.com 下载最新版本");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Copyright © 2019 YuxianStudio. All Rights Reserved. 使用有问题请联系:yuxianstudio@gmail.com");
                Console.WriteLine("");
                Console.WriteLine("非常重要：请确保该程序在根目录下!!!");
                Console.WriteLine("");
                Console.WriteLine("检测到客户端有新版本，是否更新?");
                Console.WriteLine("");
                Console.WriteLine("若更新，请按“回车”继续");
                Console.WriteLine("若暂不更新，请关闭该窗口");
                Console.ReadLine();
                Console.WriteLine("开始更新！");
                Console.WriteLine("");
                //删除旧版本Mod
                string DeMod1 = @".minecraft/mods/test.jar";
                File.Delete(DeMod1);
                string DeMod2 = @".minecraft/mods/test.jar";
                File.Delete(DeMod2);
                //更新客户端Mod
                Console.WriteLine("开始更新test.jar！");
                WebClient webClient1 = new WebClient();
                webClient1.DownloadFile("https://yuxstudio-minecraft-1252460563.cos.ap-guangzhou.myqcloud.com/mods/test.jar", ".minecraft/mods/.jar");
                Console.WriteLine("更新.jar完成!");
                Console.WriteLine("开始更新.jar！");
                WebClient webClient2 = new WebClient();
                webClient2.DownloadFile("https://yuxstudio-minecraft-1252460563.cos.ap-guangzhou.myqcloud.com/mods/test.jar", ".minecraft/mods/.jar");
                Console.WriteLine("更新.jar完成!");
                Console.WriteLine("开始更新.jar！");
                WebClient webClient3 = new WebClient();
                webClient3.DownloadFile("https://yuxstudio-minecraft-1252460563.cos.ap-guangzhou.myqcloud.com/mods/test.jar", ".minecraft/mods/.jar");
                Console.WriteLine("更新.jar完成!");
                //更新客户端版本号
                WebClient webClient233 = new WebClient();
                webClient233.DownloadFile("https://yuxstudio-minecraft-1252460563.cos.ap-guangzhou.myqcloud.com/3.1.3.clientversion", ".minecraft/versions/3.1.3.clientversion");
                Console.WriteLine("更新客户端版本号完成!");
                Console.WriteLine("");
                Console.WriteLine("更新客户端完成!");
                Console.WriteLine("请按“回车”关闭窗口");
                Console.ReadLine();
            }
        }
    }
}
