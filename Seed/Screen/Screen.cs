using Microsoft.Xna.Framework.Graphics;
using Seed.Enums;

namespace Seed.Screen
{
    public abstract class Screen : IScreen
    {
        public ScreenState ScreenState { get; private set; }

        public abstract void Update(float deltaTime);
        public abstract void Draw(SpriteBatch spriteBatch);

        public void SetScreenState(ScreenState screenState)
        {
            ScreenState = screenState;
        }
    }
}