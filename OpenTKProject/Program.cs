using SimpleScene.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleScene
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MainScene scene = new MainScene(800, 600, "Simple Scene"))
            {
                scene.Run(60.0);
            }
        }
    }
}
