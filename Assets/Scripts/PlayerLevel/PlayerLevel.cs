using Grid.GridData;
using UI;

namespace PlayerLevel
{
    public abstract class PlayerLevel : LevelBase
    {
        protected AbstractUILevel uiLevel;
         
        public abstract void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel);

        public abstract GridItemData GetGritItemDataAtPoint(Point point);

        public abstract bool IsGridFilledCorrect();

        public abstract GridItemData GetResultDataForUpdateCell(Point point);
    }
}