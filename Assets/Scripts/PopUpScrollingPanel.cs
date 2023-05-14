using System.Collections.Generic;
using Data;
using Grid.GridItems;
using PlayerLevel;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScrollingPanel : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject parent;
    [SerializeField] private UILevel1 level;

    private List<ScrollingElement> scrollingElements;
    private bool isNegative = false;

    private ScrollingElement activeScrollingElement;

    public delegate void OnButtonClicked(ScrollingElement scrollingElement);
    
    private void Awake()
    {
        scrollingElements = new List<ScrollingElement>();
        Initialize();
    }
    
    private void Initialize()
    {
        foreach (var value in AvailableValuesForLevel1.AvailableValue)
        {
            GameObject gm = Instantiate(prefab, parent.transform);
            ScrollingElement scrollingElement = gm.GetComponent<ScrollingElement>();
            scrollingElement.SetValues(value);
            scrollingElement.SetOnButtonClicked(OnButtonItemClicked);
            scrollingElements.Add(scrollingElement);
        }
    }

    public void OnGridItemClicked(GridItem gridItem)
    {
        IrrationalNumber number = ((PlayerLevel1)level.PlayerLevel).GetGridValue(gridItem.Point);

        if (number != null)
        {
            foreach (var element in scrollingElements)
            {
                if (element.Number.EqualsAbs(number))
                {
                    SetScrollingElementActive(element);

                    isNegative = number.number < 0;
                    ChangeScrollingElementSign(isNegative);
                    
                    break;
                }
            }
        }
        else
        {
            SetScrollingElementActive(null);
        }
    }

    private void OnButtonItemClicked(ScrollingElement scrollingElement)
    {
        SetScrollingElementActive(scrollingElement);
        if (scrollingElement != null)
        {
            level.OnButtonScrollingElementClicked(scrollingElement.Number);
        }
    }

    private void SetScrollingElementActive(ScrollingElement scrollingElement)
    {
        activeScrollingElement = scrollingElement;
        foreach (var element in scrollingElements)
        {
            element.SetBorderImageActive(scrollingElement != null && element == scrollingElement);
        }
    }

    public void OnButtonChangeSignClicked()
    {
        isNegative = !isNegative;
        ChangeScrollingElementSign(isNegative);
        OnButtonItemClicked(activeScrollingElement);
        
    }

    private void ChangeScrollingElementSign(bool isNegative)
    {
        for (int i = 0; i < scrollingElements.Count; i++)
        {
            scrollingElements[i].SetValues(isNegative
                ? AvailableValuesForLevel1.AvailableValue[i].SetNegative()
                : AvailableValuesForLevel1.AvailableValue[i]);
        }
    }

    public void OnButtonBackClicked()
    {
        level.OnButtonScrollingBackClicked();   
    }
    
}
