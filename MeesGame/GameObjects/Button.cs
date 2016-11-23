using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MeesGame.GameObjects
{
    class Button : IGameComponent
    {
        Vector2 position;

        public Button(Sprite texture, Vector2 position)
        {
            this = texture;
        }

        public Button(SpriteBatch text, Vector2 position)
        
        public bool enterButton()
        {
            if (MouseInput.getMouseX() < buttonX + Texture.Width &&
                    MouseInput.getMouseX() > buttonX &&
                    MouseInput.getMouseY() < buttonY + Texture.Height &&
                    MouseInput.getMouseY() > buttonY)
            {
                return true;
            }
            return false;
        }

        public void Update(GameTime gameTime)
        {
            if (enterButton() && MouseInput.LastMouseState.LeftButton == ButtonState.Released && MouseInput.MouseState.LeftButton == ButtonState.Pressed)
            {
                switch (Name)
                {
                    case "buy_normal_fish": //the name of the button
                        if (Player.Gold >= 10)
                        {
                            ScreenManager.addFriendly("normal_fish", new Vector2(100, 100), 100, -3, 10, 100);
                            Player.Gold -= 10;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public void Draw()
        {
            Screens.ScreenManager.Sprites.Draw(Texture, new Rectangle((int)ButtonX, (int)ButtonY, Texture.Width, Texture.Height), Color.White);
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }

}
}
