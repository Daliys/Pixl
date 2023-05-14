using UnityEngine;

namespace UI
{
    public abstract class AbstractUILevel : MonoBehaviour
    {
        
        [SerializeField] protected Point gridSize;
        
        protected LevelGenerator levelGenerator;
        protected LevelSolver.LevelSolver levelSolver;
        protected PlayerLevel.PlayerLevel playerLevel;
        

        public abstract void InitializeOnAwake();

        public abstract void OnButtonCheckResultClicked();

        public abstract void OnButtonBackExplanationPanelClicked();
        
        public LevelBase PlayerLevel => playerLevel;
        public LevelGenerator LevelGenerator => levelGenerator;
        public LevelSolver.LevelSolver LevelSolver => levelSolver;
    }
}