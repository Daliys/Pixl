using System;
using System.Text;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestAnswerButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private Image buttonImage;
    [SerializeField] private int index;
    
    public delegate void ButtonClicked(int index);

    private ButtonClicked onButtonClicked;
    
    public void Initialize(ButtonClicked buttonClicked)
    {
        this.onButtonClicked = buttonClicked;
    }

    public void SetButtonValue(string text)
    {
        buttonImage.gameObject.SetActive(false);
        buttonText.gameObject.SetActive(true);
       
        StringBuilder resultString = new StringBuilder(text);
        
        string substringToFind = "\\n";
        string replacementString = "\n";
        
        int ind = resultString.ToString().IndexOf(substringToFind, StringComparison.Ordinal);
        while (ind != -1)
        {
            resultString = resultString.Remove(ind, substringToFind.Length)
                .Insert(ind, replacementString);
            ind = resultString.ToString().IndexOf(substringToFind, ind + replacementString.Length, StringComparison.Ordinal);
        }
        
        buttonText.text = resultString.ToString();
    }

    public void SetButtonValue(Sprite sprite)
    {
        buttonImage.gameObject.SetActive(true);
        buttonText.gameObject.SetActive(false);
        buttonImage.sprite = sprite;
        buttonImage.preserveAspect = true;
    }

    public void OnButtonClicked()
    {
        onButtonClicked?.Invoke(index);
    }

}