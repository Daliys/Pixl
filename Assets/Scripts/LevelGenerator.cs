using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : LevelBase
{
    private float fillCoef = 0.5f;
    public void Initialize(Point gridSize)
    {
        grid = new bool[gridSize.x, gridSize.y];
        this.gridSize = gridSize;

        StartGeneration();
    }

    private void StartGeneration()
    {
        List<Point> availableToTake = new List<Point>();
        List<Point> notToUsePoints = GetRandomPoints(6);
        
        Point startPoint = new Point(Random.Range(0, gridSize.x), Random.Range(0, gridSize.y));
        SetGridValue(startPoint);
        availableToTake.Add(startPoint);

        int fillCount = (int)(gridSize.x * gridSize.y * fillCoef);
        int counterLimiter = 0;
        int ignoreCounter = 0;
        
        for (int i = 0; i < fillCount;)
        {
            if (counterLimiter++ > 300)
            {
                return;
            }
            
            if (availableToTake.Count == 0) return;

            Point randomPoint = availableToTake[Random.Range(0, availableToTake.Count)];
            
            if (!IsHaveAvailableAround(randomPoint))
            {
                availableToTake.Remove(randomPoint);
                continue;
            }

            Point randomNearbyPoint = GetRandomNearbyCell(randomPoint);
            if (!notToUsePoints.Contains(randomNearbyPoint) || ignoreCounter++ > 20)
            {
                availableToTake.Add(randomNearbyPoint);
                SetGridValue(randomNearbyPoint);
                i++;
                ignoreCounter = 0;
            }
        }
    }

    private Point GetRandomNearbyCell(Point point)
    {
        List<Point> availableToPlace = new List<Point>();
        if (IsPointInRangeAndEmpty(point.Right())) availableToPlace.Add(point.Right());
        if (IsPointInRangeAndEmpty(point.Left())) availableToPlace.Add(point.Left());
        if (IsPointInRangeAndEmpty(point.Up())) availableToPlace.Add(point.Up());
        if (IsPointInRangeAndEmpty(point.Down())) availableToPlace.Add(point.Down());
        
        if (IsPointInRangeAndEmpty(point.RightUp())) availableToPlace.Add(point.RightUp());
        if (IsPointInRangeAndEmpty(point.RightDown())) availableToPlace.Add(point.RightDown());
        if (IsPointInRangeAndEmpty(point.LeftUp())) availableToPlace.Add(point.LeftUp());
        if (IsPointInRangeAndEmpty(point.LeftDown())) availableToPlace.Add(point.LeftDown());

        return availableToPlace[Random.Range(0, availableToPlace.Count)];
    }

    private bool IsHaveAvailableAround(Point point)
    {
        if (IsPointInRangeAndEmpty(point.Right())) return true;
        if (IsPointInRangeAndEmpty(point.Left())) return true;
        if (IsPointInRangeAndEmpty(point.Up())) return true;
        if (IsPointInRangeAndEmpty(point.Down())) return true;
        
        if (IsPointInRangeAndEmpty(point.RightDown())) return true;
        if (IsPointInRangeAndEmpty(point.RightUp())) return true;
        if (IsPointInRangeAndEmpty(point.LeftUp())) return true;
        if (IsPointInRangeAndEmpty(point.LeftDown())) return true;
        
        return false;
    }
    
    private List<Point> GetRandomPoints(int count)
    {
        List<Point> randomPoints = new List<Point>();
   
        for (int i = 0; i < count;)
        {
            Point rand = new Point(Random.Range(0, gridSize.x), Random.Range(0, gridSize.y));
            if (!randomPoints.Contains(rand) && !IsPointHaveNearbyAnyPointFromMassive(randomPoints, rand))
            {
                randomPoints.Add(rand);
                i++;
            }
        }
        
        return randomPoints;
    }

    private bool IsPointHaveNearbyAnyPointFromMassive(List<Point> points, Point point)
    {
        foreach (var listPoint in points)
        {
            if (listPoint.Equals(point.Right())) return true;
            if (listPoint.Equals(point.Left())) return true;
            if (listPoint.Equals(point.Up())) return true;
            if (listPoint.Equals(point.Down())) return true;
        }

        return false;
    }


}
