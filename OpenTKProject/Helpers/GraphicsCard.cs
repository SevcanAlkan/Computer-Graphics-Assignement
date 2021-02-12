using OpenTK.Graphics.ES20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleScene.Helpers
{
    public static class GraphicsCard
    {
        public static void PrintInfo()
        {
            Console.WriteLine($"Brand: {GetManufacturerName()}");
            Console.WriteLine($"Model: {GetModelName()}");
            Console.WriteLine($"Shading Language Version: {GetShadingLanguageVersion()}");
            Console.WriteLine($"Version: {GetVersion()}");

            Console.WriteLine($"Extensions");
            const string emptySpace = " ";

            foreach (var item in GetExtensions())
            {
                Console.WriteLine(item.Replace("_", emptySpace));
            }

            Console.WriteLine("EXTENSIONS" + "".PadRight(10, '-'));
        }

        public static string GetModelName()
        {
            return GL.GetString(StringName.Renderer);
        }

        public static string GetManufacturerName()
        {
            return GL.GetString(StringName.Vendor);
        }

        public static string GetShadingLanguageVersion()
        {
            return GL.GetString(StringName.ShadingLanguageVersion);
        }

        public static string[] GetExtensions()
        {
            return GL.GetString(StringName.Extensions).Split((char)32);
        }

        public static string GetVersion()
        {
            return GL.GetString(StringName.Version);
        }
    }
}
