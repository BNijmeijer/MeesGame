using Microsoft.Xna.Framework.Content;

namespace MeesGame
{
    internal class PlayingState : IGameLoopObject
    {
        private ContentManager content;

        public PlayingState(ContentManager content)
        {
            this.content = content;
        }
    }
}