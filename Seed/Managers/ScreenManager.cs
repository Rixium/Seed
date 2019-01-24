using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Seed.Screen;

namespace Seed.Managers
{
    public class ScreenManager
    {
        private readonly List<IScreen> _screens;

        public ScreenManager()
        {
            _screens = new List<IScreen>();
        }

        public void AddScreen(IScreen screen)
        {
            _screens.Add(screen);
        }

        // Removes the screen from the top of the stack.
        public void RemoveScreen(IScreen screen)
        {
            if (_screens.Count <= 0) return;
            _screens.Remove(screen);
        }
        
        public void Update(float deltaTime)
        {
            foreach (var screen in _screens)
                screen.Update(deltaTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(var screen in _screens)
                screen.Draw(spriteBatch);
        }

    }
}