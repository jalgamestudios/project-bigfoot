using ProjectBigfoot.Engine.SceneManagment;
using ProjectBigfoot.Scenes.Ingame.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Scenes.Ingame
{
    class IngameScene : IScene
    {
        public void init()
        {
            WorldManager.init();
        }

        public void update()
        {
            WorldManager.update();
        }

        public void draw()
        {
            WorldManager.draw();
        }
    }
}
