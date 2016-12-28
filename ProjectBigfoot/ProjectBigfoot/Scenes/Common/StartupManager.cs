using ProjectBigfoot.Engine.SceneManagment;
using ProjectBigfoot.Scenes.Ingame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Scenes.Common
{
    static class StartupManager
    {
        public static void startUp()
        {
            createScenes();
        }

        private static void createScenes()
        {
            SceneManager.scenes.Add("ingame", new IngameScene());
            SceneManager.currentSceneName = "ingame";
        }
    }
}
