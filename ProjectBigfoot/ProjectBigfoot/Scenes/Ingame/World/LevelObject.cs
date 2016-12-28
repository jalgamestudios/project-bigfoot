using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectBigfoot.Rendering;
using ProjectBigfoot.Scenes.Ingame.Camera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Scenes.Ingame.World
{
    class LevelObject
    {
        #region Variables

        public Vector2 position { get; set; }
        public Vector2 size { get; set; }
        public Texture2D texture { get; set; }

        #endregion


        #region Constructors

        public LevelObject(Vector2 position, Vector2 size, Texture2D texture)
        {
            this.position = position;
            this.size = size;
            this.texture = texture;
        }

        #endregion


        #region Functions

        public void update()
        {

        }

        public void draw()
        {
            RenderingManager.spriteBatch.Draw(texture, CameraManager.getScreenPosition(position, size), Color.White);
        }

        #endregion
    }
}
