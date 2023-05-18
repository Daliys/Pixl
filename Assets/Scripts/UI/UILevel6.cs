using Grid.GridFillers;
using Grid.GridItems;
using LevelSolver;
using PlayerLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI
{
    public class UILevel6 : AbstractUILevel
    {
        
        [SerializeField] private GridFiller playerGridFiller;
        [FormerlySerializedAs("previousGridFiller")] [SerializeField] private GridFillerPreview gridFillerPreview;

        [SerializeField] private TextMeshProUGUI iterationText;
        [SerializeField] private GameObject previousIterationButton;
        [SerializeField] private GameObject previousIterationPanel;

        [SerializeField] private GameObject timerAreaPanel;

        public override void InitializeOnAwake()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel6();
            playerLevel = new PlayerLevel6();

            
            previousIterationPanel.SetActive(false);
            previousIterationButton.SetActive(false);


            playerGridFiller.Initialize(gridSize, this);
            gridFillerPreview.Initialize(gridSize, this);
            
            levelGenerator.Initialize(gridSize);
            levelSolver.Initialize(levelGenerator.Grid, this);
            ((PlayerLevel6)PlayerLevel).Initialize(levelGenerator.Grid, this);

            UpdateIterationNumber();

        }

        public override void OnButtonGridItemClicked(GridItem gridItem)
        {

        }

        public override void OnButtonCheckResultClicked()
        {
            previousIterationPanel.SetActive(false);
            
            //resultPanel.GetComponent<ResultUI>().InitializeResultPanel(playerLevel.IsResultCorrect);

        }

        public override void OnButtonBackExplanationPanelClicked()
        {
            
        }


        public void OnButtonEditPreviousStepClicked()
        {
            //playerGridFiller.UpdateGridByPreviousGridValues();
            ((PlayerLevel6)PlayerLevel).OnButtonEditPreviousClicked();

            if (((PlayerLevel6)PlayerLevel).PlayerIterations.Count <= 1)
            {
                previousIterationPanel.SetActive(false);
                previousIterationButton.SetActive(false);
            }
            else
            {
                gridFillerPreview.UpdatePreviousStepGrid();
            }
            UpdateIterationNumber();
        }
        
        
        public void OnButtonNextIterationClicked()
        {

      
            /*levelGenerator = new LevelGenerator();
            levelGenerator.Initialize(gridSize);*/
       
            /*
            levelSolver.Initialize(levelGenerator.Grid);
            ((ClickableWithTextGridFiller)playerGridFiller).UpdateGridByCorrectAnswer();
            */
        
            //playerGridFiller.UpdateGridByPlayerLevelGrid();
            //playerLevel.SaveIteration();
        
            //for debug
        
            /*
        print("CurrentIter " + playerLevel.GetCurrentIteration());
        previousIterationPanel.SetActive(true);
        previousGridFiller.UpdateByCorrectAnswer();
        */
        
        
            //TODO temprary
            /*
        if (playerLevel.PlayerIterations.Count > 1)
        {
            previousIterationPanel.SetActive(true);
            previousIterationButton.SetActive(true);
            previousGridFiller.UpdatePreviousStepGrid();
        }
        */
            UpdateIterationNumber();
        }
        
        private void UpdateIterationNumber()
        {
            iterationText.text = $"{((PlayerLevel6)PlayerLevel).GetCurrentIteration(),0:D2}";
        }
        
        
    }
}