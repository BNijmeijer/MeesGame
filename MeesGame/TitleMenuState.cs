using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MeesGame
{
    class TitleMenuState : IGameLoopObject
    {
        private SpriteFont arial;

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(arial, Strings.new_game, new Vector2(10, 10), Color.Red);
            spriteBatch.DrawString(arial, Strings.map_editor, new Vector2(10, 30), Color.Red);
            spriteBatch.DrawString(arial, Strings.exit, new Vector2(10, 50), Color.Red);
        }

        public void HandleInput(InputHelper inputHelper)
        {
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}