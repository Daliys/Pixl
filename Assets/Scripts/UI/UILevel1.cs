using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Data;
using Grid.GridData;
using Grid.GridFillers;
using Grid.GridItems;
using LevelSolver;
using PlayerLevel;
using UnityEngine;

namespace UI
{
    public class UILevel1 : AbstractUILevel
    {
        [SerializeField] private GridFillerClickableWithText gridFiller;
        [SerializeField] private GameObject popUpScrollingPanel;
        [SerializeField] private GameObject informationPanel;
        [SerializeField] private GameObject resultPanel;
        
        private PopUpScrollingPanel popUpScrollingPanelClass;
        private bool isCheckButtonPressed;

        // #Temproraty DEBUG
        private int counter = 0;
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        
        public override void InitializeOnAwake()
        {
            popUpScrollingPanelClass = popUpScrollingPanel.GetComponent<PopUpScrollingPanel>();
            
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel1();
            playerLevel = new PlayerLevel1();
            
            gridFiller.Initialize(gridSize, this);
            
            levelGenerator.Initialize(gridSize);
            levelSolver.Initialize(levelGenerator.Grid);
            GetPlayerLevel().Initialize(levelGenerator.Grid, this);
            
            gridFiller.UpdateGridByPlayerGrid();

        }

        public void OnButtonItemClicked(GridItem gridItem)
        {
            if (isCheckButtonPressed)
            {
                gridFiller.UpdateGridByExplanationMistakeResultAnswer(gridItem);
                UIResultPanel resultUI = resultPanel.GetComponent<UIResultPanel>();

                GridItemData correctData = GetLevelSolver().GetGridItemDataAtPoint(gridItem.Point);
                GridItemData playerData = GetPlayerLevel().GetPlayerDataForUpdateCell(gridItem.Point);
                resultUI.InitializeErrorDescriptionPanel(correctData, playerData);
            }
            else
            {
                OnButtonItemClickedInGame(gridItem);
            }
        }

        private void OnButtonItemClickedInGame(GridItem gridItem)
        {
            bool isActive = gridFiller.SelectedGridItem != null;
            popUpScrollingPanel.SetActive(isActive);
            Reference.reference.UIController.SetActiveBottomPanel(!isActive);
            popUpScrollingPanelClass.OnGridItemClicked(gridItem);
            gridFiller.UpdateGridByPlayerGrid();
        }

        public override void OnButtonCheckResultClicked()
        {
            isCheckButtonPressed = true;
            
            gridFiller.UpdateGridByCheckResultAnswer();
            informationPanel.SetActive(false);
            Reference.reference.UIController.SetActiveBottomPanel(false);
            resultPanel.SetActive(true);
            UIResultPanel resultUI = resultPanel.GetComponent<UIResultPanel>();
            bool isGridFilledCorrect = GetPlayerLevel().IsGridFilledCorrect();

            resultUI.InitializeStartPanel(isGridFilledCorrect? ResultStatus.Correct : ResultStatus.WrongValue);
        }

        public override void OnButtonBackExplanationPanelClicked()
        {
            OnButtonCheckResultClicked();
        }


        public void OnButtonScrollingBackClicked()
        {
            gridFiller.SetSelectedGridItem(null);
            gridFiller.UpdateGridByPlayerGrid();
            popUpScrollingPanel.SetActive(false);
            Reference.reference.UIController.SetActiveBottomPanel(true);
        }

        public void OnButtonScrollingElementClicked(IrrationalNumber number)
        {
            Point point = gridFiller.SelectedGridItem.Point;
            GetPlayerLevel().SetGridValue(point, number);
            gridFiller.UpdateSelectedGridItem(number.ToString());
        }


        private IEnumerator Statistic()
        {
            for (int ll = 0; ll < 1000; ll++)
            {
                for (int iter = 0; iter < 1000; iter++)
                {
                    LevelGenerator generator = new LevelGenerator();
                    generator.Initialize(gridSize);
                    levelSolver.Initialize(generator.Grid);
                    IrrationalNumber[,] values = ((LevelSolverLevel1)levelSolver).gridValues;

                    for (int i = 0; i < gridSize.x; i++)
                    {
                        for (int j = 0; j < gridSize.y; j++)
                        {
                            int value = values[i, j].number;
                            if (numbers.ContainsKey(Mathf.Abs(value))) numbers[Mathf.Abs(value)] += 1;
                            else numbers[Mathf.Abs(value)] = 1;
                        }
                    }
                }

                yield return null;
                print("Iter " + (ll * 1000));
            }
        
            var sortedDict = numbers.OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

        
            print("");
            print("");

            string str="";
            foreach (var variable in sortedDict)
            {
                str += "√" + variable.Key + " Кол-во : " + variable.Value + "\n";
            }
            print(str);
        }
        
        public bool IsCheckButtonPressed => isCheckButtonPressed;

        private PlayerLevel1 GetPlayerLevel() => (PlayerLevel1) playerLevel;
        private LevelSolverLevel1 GetLevelSolver() => (LevelSolverLevel1) levelSolver;
        
        public GridFillerClickableWithText GridFiller => gridFiller;
    }
}
