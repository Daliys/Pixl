using System;
using Data;

namespace LevelSolver
{
    public class LevelSolverLevel3 : LevelSolverLevel1
    {
        protected override Point CompareAndGetLowestDistancePoint(Point pointToCheck, Point originalPoint, Point lowestDistancePoint,
            bool initValue)
        {
            if (IsPointInRange(pointToCheck) && GetGridValue(pointToCheck) == !initValue)
            {
                if (lowestDistancePoint == null) return pointToCheck;

                int irCheck = Math.Max(Math.Abs(pointToCheck.x - originalPoint.x), Math.Abs(pointToCheck.y - originalPoint.y));
                int irLowest = Math.Max(Math.Abs(lowestDistancePoint.x - originalPoint.x), Math.Abs(lowestDistancePoint.y - originalPoint.y));

                return irCheck < irLowest ? pointToCheck : lowestDistancePoint;
            }

            return lowestDistancePoint;
        }

        protected override void SetDistanceAtGridValues(Point settingPoint, Point nearPoint)
        {
            int dist =  Math.Max(Math.Abs(settingPoint.x - nearPoint.x), Math.Abs(settingPoint.y - nearPoint.y));
            dist *= dist * (GetGridValue(settingPoint) ? 1 : -1);

            gridValues[settingPoint.x, settingPoint.y] = new IrrationalNumber(dist);
        }
    }
}