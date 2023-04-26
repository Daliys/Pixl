
public class Level1 : LevelSolver
{
  
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
                
                if(!GetGridValue(point)) continue;

                int neighborCount = GetCountOfFilledNeighbor(point);
                if(!(neighborCount >= 2 && neighborCount <= 6)) continue;

                int neighborTransitionCount = GetCountOfNeighborTransitions(point);
                if(neighborTransitionCount != 1) continue;
                
                if(IsPointInRangeAndFilled(point.GetPoint(0)) && IsPointInRangeAndFilled(point.GetPoint(2)) 
                                                              && IsPointInRangeAndFilled(point.GetPoint(6))) continue;
                if(IsPointInRangeAndFilled(point.GetPoint(0)) && IsPointInRangeAndFilled(point.GetPoint(4))
                                                              && IsPointInRangeAndFilled(point.GetPoint(6))) continue;
                
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
                
                //Utils.print("Iter " + iterationList.Count + " Point " + point);
                
                if(!GetGridValue(point)) continue;
                //Utils.print ( "1. Filled" );
                
                int neighborCount = GetCountOfFilledNeighbor(point);
              //  Utils.print("2. " + neighborCount);
                if(neighborCount is not (>= 2 and <= 6)) continue;
              //  Utils.print("2. - true");

                int neighborTransitionCount = GetCountOfNeighborTransitions(point); 
              //  Utils.print("3. " + neighborTransitionCount);
                if(neighborTransitionCount is not 1) continue;
               // Utils.print("3. - true");
                
                if(IsPointInRangeAndFilled(point.GetPoint(0)) && IsPointInRangeAndFilled(point.GetPoint(2)) 
                                                                && IsPointInRangeAndFilled(point.GetPoint(4))) continue;
                //Utils.print("4. >");
                if(IsPointInRangeAndFilled(point.GetPoint(2)) && IsPointInRangeAndFilled(point.GetPoint(4))
                                                                && IsPointInRangeAndFilled(point.GetPoint(6))) continue;
                //Utils.print("5. _-_");
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
            Point pointSide = point.GetPoint(i%8);
            if (i == 0)
            {
                currentState = IsPointInRange(pointSide) && GetGridValue(pointSide) ;
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

}
