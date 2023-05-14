using UI;

namespace PlayerLevel
{
    public abstract class PlayerLevel : LevelBase
    {
        protected AbstractUILevel uiLevel;
         
        public abstract void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel);
    }
}