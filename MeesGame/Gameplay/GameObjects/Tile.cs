namespace MeesGame
{
    class Tile : SpriteGameObject
    {
        protected int tileType;
        public Tile (string assetName, int tileType, int layer = 0, string id = "") : base(assetName, layer, id)
        {
            this.tileType = tileType;
        }
    }
}
