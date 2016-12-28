using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Engine.SceneManagment
{
    interface IScene
    {
        void init();
        void update();
        void draw();
    }
}
