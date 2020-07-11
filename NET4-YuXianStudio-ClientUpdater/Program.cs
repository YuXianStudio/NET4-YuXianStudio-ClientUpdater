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
            //枚举客户端版本
            string LatestVersion = ".minecraft/versions/3.1.3.clientversion";
            string PreviousVersion = ".minecraft/versions/3.1.2.clientversion";
            string OlderVersion = ".minecraft/versions/3.1.1.clientversion";
            //END
            Console.WriteLine("");
            Console.WriteLine("Copyright © 2020 YuxianStudio. All Rights Reserved. 使用有问题请联系:yuxianstudio@gmail.com");
            Console.WriteLine("");
            Console.WriteLine("非常重要：请确保该程序在根目录下!!!");
            Console.WriteLine("");
            if (File.Exists(LatestVersion))//判断客户端版本
            {
                Console.WriteLine("检测到客户端已经是最新版本，无需更新");
                Console.WriteLine("");
                Console.WriteLine("若客户端无法启动，请前往官网 https://mc.yuxianstudio.com 下载最新版本");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("检测到客户端有新版本，是否更新?");
                Console.WriteLine("");
                Console.WriteLine("若更新，请按“回车”继续");
                Console.WriteLine("若暂不更新，请关闭该窗口");
                Console.ReadLine();
                Console.WriteLine("开始更新！");
                Console.WriteLine("");
                if (File.Exists(PreviousVersion))//判断客户端版本
                {
                    //删除旧版本Mod
                    string DeMod1 = @".minecraft/mods/test.jar";
                    File.Delete(DeMod1);//写法一

                    File.Delete(@".minecraft/mods/test.jar");//写法二
                    //END

                    //更新客户端Mod
                    WebClient webClient = new WebClient();
                    Console.WriteLine("开始更新test.jar！");
                    webClient.DownloadFile("https://mc.yuxianstudio.com/mods/test.jar", ".minecraft/mods/.jar");
                    Console.WriteLine("更新.jar完成!");
                    //
                    Console.WriteLine("开始更新.jar！");
                    webClient.DownloadFile("https://mc.yuxianstudio.com/mods/test.jar", ".minecraft/mods/.jar");
                    Console.WriteLine("更新.jar完成!");
                    //
                    Console.WriteLine("开始更新.jar！");
                    webClient.DownloadFile("https://mc.yuxianstudio.com/mods/test.jar", ".minecraft/mods/.jar");
                    Console.WriteLine("更新.jar完成!");
                    //END

                    //更新客户端版本号
                    webClient.DownloadFile("https://mc.yuxianstudio.com/3.1.3.clientversion", ".minecraft/versions/3.1.3.clientversion");
                    Console.WriteLine("更新客户端版本号完成!");
                    File.Delete(@".minecraft/versions/3.1.2.clientversion");
                    Console.WriteLine("");
                    Console.WriteLine("更新客户端完成!");
                    Console.WriteLine("请按“回车”关闭窗口");
                    Console.ReadLine();
                }
                if (File.Exists(OlderVersion))//判断客户端版本
                {
                    //删除旧版本Mod
                    string DeMod1 = @".minecraft/mods/test.jar";
                    File.Delete(DeMod1);//写法一

                    File.Delete(@".minecraft/mods/test.jar");//写法二
                    //END

                    //更新客户端Mod
                    WebClient webClient = new WebClient();
                    Console.WriteLine("开始更新test.jar！");
                    webClient.DownloadFile("https://mc.yuxianstudio.com/mods/test.jar", ".minecraft/mods/.jar");
                    Console.WriteLine("更新.jar完成!");
                    //
                    Console.WriteLine("开始更新.jar！");
                    webClient.DownloadFile("https://mc.yuxianstudio.com/mods/test.jar", ".minecraft/mods/.jar");
                    Console.WriteLine("更新.jar完成!");
                    //
                    Console.WriteLine("开始更新.jar！");
                    webClient.DownloadFile("https://mc.yuxianstudio.com/mods/test.jar", ".minecraft/mods/.jar");
                    Console.WriteLine("更新.jar完成!");
                    //END

                    //更新客户端版本号
                    webClient.DownloadFile("https://mc.yuxianstudio.com/3.1.3.clientversion", ".minecraft/versions/3.1.3.clientversion");
                    Console.WriteLine("更新客户端版本号完成!");
                    File.Delete(@".minecraft/versions/3.1.1.clientversion");
                    Console.WriteLine("");
                    Console.WriteLine("更新客户端完成!");
                    Console.WriteLine("请按“回车”关闭窗口");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("检测到客户端版本过旧，请前往官网 https://mc.yuxianstudio.com 下载最新版本");
                    Console.WriteLine("");
                    Console.WriteLine("请按“回车”关闭窗口");
                    Console.ReadLine();
                }
            }
        }
    }
}