﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBigfoot.Rendering
{
    class RenderingManager
    {
        #region Variables

        static float resultion = 2f;
        public static Point screenDimensions { get { return new Point(graphicsDeviceManager.PreferredBackBufferWidth, graphicsDeviceManager.PreferredBackBufferHeight); } }

        private static RenderTarget2D mainRenderTarget { get; set; }

        public static GraphicsDeviceManager graphicsDeviceManager { get; set; }
        public static GraphicsDevice graphicsDevice { get { return graphicsDeviceManager.GraphicsDevice; } }
        public static SpriteBatch spriteBatch { get; set; }
        public static ContentManager contentManager { get; set; }

        #endregion


        #region Functions

        public static void init(GraphicsDeviceManager graphicsDeviceManager, SpriteBatch spriteBatch, ContentManager contentManager)
        {
            RenderingManager.graphicsDeviceManager = graphicsDeviceManager;
            RenderingManager.spriteBatch = spriteBatch;
            RenderingManager.contentManager = contentManager;

            mainRenderTarget = new RenderTarget2D(graphicsDevice, screenDimensions.X, screenDimensions.Y);
        }

        public static void startDraw()
        {
            if (mainRenderTarget.Width != screenDimensions.X ||
                mainRenderTarget.Height != screenDimensions.Y)
                mainRenderTarget = new RenderTarget2D(graphicsDevice, screenDimensions.X, screenDimensions.Y);

            graphicsDevice.SetRenderTarget(mainRenderTarget);
            graphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

        }

        public static void endDraw()
        {
            spriteBatch.End();

            graphicsDevice.SetRenderTarget(null);
            graphicsDevice.Clear(Color.DarkGray);
            spriteBatch.Begin();
            spriteBatch.Draw(mainRenderTarget, new Rectangle(0, 0, graphicsDeviceManager.PreferredBackBufferWidth, graphicsDeviceManager.PreferredBackBufferHeight), Color.White);
            spriteBatch.End();
        }

        #endregion
    }
}
