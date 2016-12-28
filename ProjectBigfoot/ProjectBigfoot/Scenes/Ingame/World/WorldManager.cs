using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Scenes.Ingame.World
{
    static class WorldManager
    {
        #region Variables

        public static List<ObjectLayer> layers { get; set; }

        #endregion


        #region Functions

        public static void init()
        {
            layers = new List<ObjectLayer>();
            ObjectLayer test = new ObjectLayer();
            //test.objects.Add(new LevelObject())
            layers.Add(test);

        }

        public static void update()
        {
            foreach (var layer in layers)
                layer.update();
        }

        public static void draw()
        {
            foreach (var layer in layers)
                layer.draw();
        }

        #endregion
    }
}
