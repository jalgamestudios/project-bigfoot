using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using ProjectBigfoot.Engine.SceneManagment;
using ProjectBigfoot.Rendering;
using ProjectBigfoot.Scenes.Common;

namespace ProjectBigfoot
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SceneManager.init();
            RenderingManager.init(graphics, spriteBatch, Content);
            StartupManager.startUp();
        }
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            SceneManager.update();
        }
        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            RenderingManager.startDraw();
            SceneManager.draw();
            RenderingManager.endDraw();
        }
    }
}

