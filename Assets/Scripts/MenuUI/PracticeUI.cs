using ScriptableObjects;
using UnityEngine;

namespace MenuUI
{
    public class PracticeUI : AbstractCardsUI
    {
        [SerializeField] private PracticeCards practiceCards;
        
        
        public override void Initialize()
        {
            if (isInitialize)
            {
                Vector3 pos = contentPanel.transform.localPosition;
                pos.y = 0;
                contentPanel.transform.localPosition = pos;

                return;
            }
        
            int i = 1;
            foreach (var model in practiceCards.models)
            {
                GameObject gm = Instantiate(cardPrefab, contentPanel.transform);
                CardBasic card = gm.GetComponent<CardBasic>();
                card.Initialize(OnButtonCardClicked,i, model.name);
                i++;
            }

            isInitialize = true;
        }

        protected override void OnButtonCardClicked(int index)
        {
            
        }
        
    }
}