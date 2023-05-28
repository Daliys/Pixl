using Grid.GridItems;
using UnityEngine;

namespace UI
{
    public abstract class AbstractUILevel : MonoBehaviour
    {
        [SerializeField] protected Point gridSize;
        [SerializeField] protected GameObject informationPanel;
        [SerializeField] protected GameObject resultPanel;

        protected LevelGenerator levelGenerator;
        protected LevelSolver.LevelSolver levelSolver;
        protected PlayerLevel.PlayerLevel playerLevel;
        
        protected bool isCheckButtonPressed;

        
        public abstract void InitializeOnAwake();

        public abstract void OnButtonGridItemClicked(GridItem gridItem);

        public void OnButtonMenuClicked()
        {
            Reference.reference.UIController.OnButtonMainMenuClicked();
        }

        public void OnButtonWikiClicked()
        {
            Reference.reference.UIController.OnButtonWikiClicked();
        }

        public void OnButtonAgainClicked()
        {
            Reference.reference.UIController.StartAgainLevel();
        }
        
        public abstract void OnButtonCheckResultClicked();

        public abstract void OnButtonBackExplanationPanelClicked();
        
        public PlayerLevel.PlayerLevel PlayerLevel => playerLevel;
        public LevelGenerator LevelGenerator => levelGenerator;
        public LevelSolver.LevelSolver LevelSolver => levelSolver;
    }
}