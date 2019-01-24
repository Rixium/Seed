using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Seed.Managers;
using Seed.Screen;
using Seed.Util;

namespace Seed
{
    public class Main : Game
    {

        public readonly GraphicsDeviceManager Graphics;
        public readonly ScreenManager ScreenManager;
        public ContentChest ContentChest;
        public SpriteBatch SpriteBatch;

        public Main()
        {
            Graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1280,
                PreferredBackBufferHeight = 720
            };

            Content.RootDirectory = "Content";

            ScreenManager = new ScreenManager();
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            ContentChest = new ContentChest(Content);

            ScreenManager.AddScreen(new MainMenuScreen());
            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            ContentChest.Load();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            var deltaTime = gameTime.ElapsedGameTime.Milliseconds / 1000f;
            ScreenManager.Update(deltaTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            ScreenManager.Draw(SpriteBatch);
            base.Draw(gameTime);
        }
    }
}