using TMPro;
using UnityEngine;

public class CardWithDescription : CardBasic
{
    [SerializeField] protected TextMeshProUGUI descriptionText;

    public void Initialize(OnButtonCardClicked onButtonCardClicked, int number, string header, string description)
    {
        base.Initialize(onButtonCardClicked, number, header);
        descriptionText.text = description;
    }

}