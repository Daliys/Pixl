using System.Collections.Generic;
using Data;
using DefaultNamespace;
using LevelSolver;
using PlayerLevel;

namespace UI
{
    public class UILevel3  : UILevel1
    {
        protected override void InitializeBasValues()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel3();
            playerLevel = new PlayerLevel1();
        }
        
        public override  List<IrrationalNumber> GetAvailableValues()
        {
            return AvailableValuesForLevel3.AvailableValue;
        }

    }
}