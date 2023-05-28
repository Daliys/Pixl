using System.Collections.Generic;
using Data;
using Grid.GridData;
using UI;

namespace LevelSolver
{
    public class LevelSolverLevel6 : LevelSolver
    {
        protected bool[,] tempGrid;
        protected List<bool[,]> iterationList;

        public override void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            base.Initialize(startingGrid, uiLevel);

            tempGrid = new bool[gridSize.x, gridSize.y];
            iterationList = new List<bool[,]>();

            tempGrid = startingGrid.Clone() as bool[,];

            StartSolving();
        }

        protected override void StartSolving()
        {
            int countOfAdded = -1;

            while (countOfAdded != 0)
            {
                countOfAdded = 0;

                countOfAdded += FirstSolvingIteration();
                grid = new bool[gridSize.x, gridSize.y];
                grid = tempGrid.Clone() as bool[,];
                iterationList.Add(tempGrid.Clone() as bool[,]);

                countOfAdded += SecondSolvingIteration();
                grid = new bool[gridSize.x, gridSize.y];
                grid = tempGrid.Clone() as bool[,];
                iterationList.Add(tempGrid.Clone() as bool[,]);
            }
        }

        private int SecondSolvingIteration()
        {
            int count = 0;

            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    Point point = new Point(i, j);

                    if (!GetGridValue(point)) continue;

                    int neighborCount = GetCountOfFilledNeighbor(point);
                    if (!(neighborCount >= 2 && neighborCount <= 6)) continue;

                    int neighborTransitionCount = GetCountOfNeighborTransitions(point);
                    if (neighborTransitionCount != 1) continue;

                    if (IsPointInRangeAndFilled(point.GetPoint(0)) && IsPointInRangeAndFilled(point.GetPoint(2))
                                                                   && IsPointInRangeAndFilled(point.GetPoint(6)))
                        continue;
                    if (IsPointInRangeAndFilled(point.GetPoint(0)) && IsPointInRangeAndFilled(point.GetPoint(4))
                                                                   && IsPointInRangeAndFilled(point.GetPoint(6)))
                        continue;

                    tempGrid[point.x, point.y] = false;
                    count++;
                }
            }

            return count;
        }

        private int FirstSolvingIteration()
        {
            int count = 0;
            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    Point point = new Point(i, j);

                    if (!GetGridValue(point)) continue;

                    int neighborCount = GetCountOfFilledNeighbor(point);
                    if (neighborCount is not (>= 2 and <= 6)) continue;

                    int neighborTransitionCount = GetCountOfNeighborTransitions(point);
                    if (neighborTransitionCount is not 1) continue;

                    if (IsPointInRangeAndFilled(point.GetPoint(0)) && IsPointInRangeAndFilled(point.GetPoint(2))
                                                                   && IsPointInRangeAndFilled(point.GetPoint(4)))
                        continue;
                    if (IsPointInRangeAndFilled(point.GetPoint(2)) && IsPointInRangeAndFilled(point.GetPoint(4))
                                                                   && IsPointInRangeAndFilled(point.GetPoint(6)))
                        continue;
                    tempGrid[point.x, point.y] = false;
                    count++;
                }
            }

            return count;
        }

        private int GetCountOfFilledNeighbor(Point point)
        {
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                if (IsPointInRangeAndFilled(point.GetPoint(i))) count++;
            }

            return count;
        }

        private int GetCountOfNeighborTransitions(Point point)
        {
            int count = 0;
            bool currentState = false;

            for (int i = 0; i < 9; i++)
            {
                Point pointSide = point.GetPoint(i % 8);
                if (i == 0)
                {
                    currentState = IsPointInRange(pointSide) && GetGridValue(pointSide);
                    continue;
                }

                if (IsPointInRange(pointSide))
                {
                    if (currentState != GetGridValue(pointSide))
                    {
                        count++;
                        currentState = GetGridValue(pointSide);
                    }
                }
                else
                {
                    if (currentState)
                    {
                        count++;
                        currentState = false;
                    }
                }
            }

            return count - 1;
        }

        public bool GetGridStatusAtLastIteration(Point point)
        {
            return iterationList[^1][point.x, point.y];
        }


        public override GridItemData[,] GetGridForResultExplanationPanel(Point point)
        {
            GridItemButtonData[,] gridItemUpdateData = new GridItemButtonData[gridSize.x, gridSize.y];

            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    CellStatus cellStatus = grid[i, j] ? CellStatus.Filled : CellStatus.Empty;
                    gridItemUpdateData[i, j] = new GridItemButtonData
                    {
                        CellStatus = cellStatus, IsButtonActive = false, IsImageAlpha100 = false
                    };
                }
            }
            CellStatus cell = grid[point.x, point.y] ? CellStatus.SelectedWhite : CellStatus.SelectedBlack;
            gridItemUpdateData[point.x,point.y] =  new GridItemButtonData
            {
                CellStatus = cell, IsButtonActive = false, IsImageAlpha100 = true
            };
            
            return gridItemUpdateData;
        }
        
        public bool GetCorrectValueAtPoint(Point point)
        {
            return grid[point.x, point.y];
        }

    }
}