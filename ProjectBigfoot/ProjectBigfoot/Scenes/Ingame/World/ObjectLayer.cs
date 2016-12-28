using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Scenes.Ingame.World
{
    class ObjectLayer
    {
        #region Variables

        public List<LevelObject> objects { get; set; }

        #endregion


        #region Constructors

        public ObjectLayer()
        {
            this.objects = new List<LevelObject>();
        }

        #endregion


        #region Functions

        public void update()
        {
            foreach (var levelObject in objects)
                levelObject.update();
        }

        public void draw()
        {
            foreach (var levelObject in objects)
                levelObject.draw();
        }

        #endregion
    }
}
