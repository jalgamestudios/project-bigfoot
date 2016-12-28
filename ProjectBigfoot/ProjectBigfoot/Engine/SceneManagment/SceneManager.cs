using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Engine.SceneManagment
{
    class SceneManager
    {
        #region Variables

        public static Dictionary<string, IScene> scenes { get; set; }

        private static string actualCurrentSceneName { get; set; } // Stores the scene name used for this frame, makes sure that scenes are only switched between frames

        public static string currentSceneName { get; set; }

        #endregion


        #region Functions

        public static void init()
        {
            scenes = new Dictionary<string, IScene>();
            actualCurrentSceneName = "";
            currentSceneName = "";
        }

        public static void update()
        {
            if (actualCurrentSceneName != currentSceneName)
            {
                actualCurrentSceneName = currentSceneName;
                scenes[currentSceneName].init();
            }
            scenes[actualCurrentSceneName].update();
        }

        public static void draw()
        {
            scenes[actualCurrentSceneName].draw();
        }

        #endregion
    }
}
