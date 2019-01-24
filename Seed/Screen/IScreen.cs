using Microsoft.Xna.Framework.Graphics;

namespace Seed.Screen
{
    public interface IScreen
    {
        void Update(float deltaTime);
        void Draw(SpriteBatch spriteBatch);
    }
}