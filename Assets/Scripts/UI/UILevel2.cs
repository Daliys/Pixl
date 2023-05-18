using System.Collections.Generic;
using Data;
using LevelSolver;
using PlayerLevel;

namespace UI
{
    public class UILevel2 : UILevel1
    {
        protected override void InitializeBasValues()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel2();
            playerLevel = new PlayerLevel1();
        }
        
        public override  List<IrrationalNumber> GetAvailableValues()
        {
            return AvailableValuesForLevel2.AvailableValue;
        }

    }
}