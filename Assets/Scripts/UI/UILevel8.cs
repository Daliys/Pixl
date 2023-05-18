using LevelSolver;
using PlayerLevel;

namespace UI
{
    public class UILevel8 : UILevel7
    {
        protected override void InitializeBasValues()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel8(mask);
            playerLevel = new PlayerLevel8();
        }
    }
}