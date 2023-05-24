using System;
using TMPro;
using UnityEngine;

public class CardBasic : MonoBehaviour
{

    [SerializeField] protected TextMeshProUGUI levelNameText;
    [SerializeField] protected TextMeshProUGUI levelNumberText;
    
    public delegate void OnButtonCardClicked(int count);
    private OnButtonCardClicked onButtonCardClicked;

    private int index;
    
    public void Initialize(OnButtonCardClicked onButtonCardClicked, int number, string header)
    {
        index = number;
        this.onButtonCardClicked = onButtonCardClicked;
        levelNumberText.text = number.ToString("D2");;
        levelNameText.text = header;
    }
    
    
    public void OnButtonClicked()
    {
        onButtonCardClicked?.Invoke(index);
    }

    private void OpenGame()
    {
        Reference.reference.GameCanvas.gameObject.SetActive(true);
        Reference.reference.UIController.NewGame();
        Reference.reference.MainMenuCanvas.gameObject.SetActive(false);
    }
}
