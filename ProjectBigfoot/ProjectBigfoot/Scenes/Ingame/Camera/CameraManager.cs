using Microsoft.Xna.Framework;
using ProjectBigfoot.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Scenes.Ingame.Camera
{
    class CameraManager
    {
        #region Variables

        public static Vector2 offset { get; set; }
        public static float scalingFactor { get { return RenderingManager.screenDimensions.X / 20f; } }
        public static Vector2 worldFrameSize { get { return RenderingManager.screenDimensions.ToVector2() / scalingFactor; } }

        #endregion


        #region Functions

        public static Rectangle getScreenPosition(Vector2 position, Vector2 size)
        {
            Vector2 offsetPosition = position - offset;
            return new Rectangle((int)(offsetPosition.X * scalingFactor), (int)(offsetPosition.Y * scalingFactor), (int)(size.X * scalingFactor), (int)(size.Y * scalingFactor));
        }

        public static Vector2 getWorldPosition(int x, int y)
        {
            return new Vector2(x, y) / scalingFactor + offset;
        }

        public static Vector2 getWorldPosition(Rectangle screenPosition)
        {
            return new Vector2(screenPosition.X, screenPosition.Y) / scalingFactor + offset;
        }

        public static Vector2 getWorldSize(int x, int y)
        {
            return new Vector2(x, y) / scalingFactor;
        }

        public static Vector2 getWorldSize(Rectangle screenPosition)
        {
            return new Vector2(screenPosition.X, screenPosition.Y) / scalingFactor;
        }

        #endregion
    }
}
