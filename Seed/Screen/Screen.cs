using Microsoft.Xna.Framework.Graphics;
using Seed.Enums;
using Seed.Managers;

namespace Seed.Screen
{
    public abstract class Screen : IScreen
    {
        protected InputManager InputManager;

        public ScreenState ScreenState { get; private set; }

        public virtual void Update(float deltaTime)
        {
            InputManager.Update(deltaTime);
        }

        public abstract void Draw(SpriteBatch spriteBatch);
        
        protected Screen()
        {
            InputManager = new InputManager();
        }

        public void SetScreenState(ScreenState screenState)
        {
            ScreenState = screenState;
        }
    }
}