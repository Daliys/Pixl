using Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingElement : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Image borderImage;
    private IrrationalNumber number;

    private PopUpScrollingPanel.OnButtonClicked onButtonClicked;

    public void SetValues(IrrationalNumber number)
    {
        this.text.text = number.ToString();
        this.number = number;
    }
    
    
    public void OnButtonClicked()
    {
        onButtonClicked?.Invoke(this);
    }


    public void SetBorderImageActive(bool isActive)
    {
        Color color = borderImage.color;
        color.a = isActive? 1f : 0f;
        borderImage.color = color;
    }


    public void SetOnButtonClicked(PopUpScrollingPanel.OnButtonClicked action)
    {
        onButtonClicked = action;
    }
    
    
    public IrrationalNumber Number => number;

}
