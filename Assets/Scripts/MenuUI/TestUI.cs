using Localization;
using ScriptableObjects;
using UnityEngine;

namespace MenuUI
{
    public class TestUI : AbstractCardsUI
    {
        [SerializeField] private TestCards testCards;
        [SerializeField] private GameObject testPage;
        
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
            foreach (var model in testCards.models)
            {
                GameObject gm = Instantiate(cardPrefab, contentPanel.transform);
                CardBasic card = gm.GetComponent<CardBasic>();
                card.Initialize(OnButtonCardClicked,i,LocalizationManager.GetLocalizationValue(model.name.value));
                i++;
            }

            isInitialize = true;
        }

        protected override void OnButtonCardClicked(int index)
        {
            testPage.SetActive(true);
            testPage.GetComponent<TestPage>().Initialize(testCards.models[index-1].questionsDataList);
            gameObject.SetActive(false);
        }

    }
}