using System.Collections.Generic;
using Data;
using Grid.GridData;
using UnityEngine;

public class Mask
{
    private bool[,] mask;
    private Point maskSize;

    public void InitializeMask(Point maskSize)
    {
        this.maskSize = maskSize;
        mask = new bool[maskSize.x, maskSize.y];
    }  
        
        
    public void GenerateRandomMask(int numberOfActiveElements)
    {
        var availablePositions = new List<Point>();
            
        Point center = new Point(maskSize.x / 2, maskSize.y / 2);
        mask[center.x, center.y] = true;
            
        for (int i = 0; i < maskSize.x; i++)
        {
            for(int j = 0; j < maskSize.y; j++)
            {
                if(new Point(i,j).Equals(center)) continue;
                    
                availablePositions.Add(new Point(i,j));
            }
        }

        for (int i = 0; i < numberOfActiveElements; i++)
        {
            int randomNumber = Random.Range(0, availablePositions.Count);
            Point rnd = availablePositions[randomNumber];
            mask[rnd.x, rnd.y] = true;
            availablePositions.RemoveAt(randomNumber);
        }
    }


    public GridItemData GetMaskGridItemAtPoint(Point point)
    {
        CellStatus cellStatus = mask[point.x, point.y] ? CellStatus.Selected : CellStatus.Empty;
        return new GridItemData { CellStatus = cellStatus };
    }


    public bool[,] GetMask() => mask;
        
    public Point MaskSize => maskSize;

}