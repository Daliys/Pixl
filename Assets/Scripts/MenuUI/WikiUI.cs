using Localization;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace MenuUI
{
    public class WikiUI : AbstractCardsUI
    {
        [SerializeField] private WikiCards wikiCards;
        [SerializeField] private GameObject wikiPage;
        [SerializeField] private Image wikiPageContentImage;
        
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
            foreach (var model in wikiCards.models)
            {
                GameObject gm = Instantiate(cardPrefab, contentPanel.transform);
                CardBasic card = gm.GetComponent<CardBasic>();
                card.Initialize(OnButtonCardClicked,i, LocalizationManager.GetLocalizationValue(model.name.value));
                i++;
            }

            isInitialize = true;
        }

        protected override void OnButtonCardClicked(int index)
        {
            wikiPage.SetActive(true);
            wikiPageContentImage.sprite = wikiCards.models[index-1].theoryContent.GetSpriteByLanguage(LocalizationManager.GetCurrentLanguage());
            wikiPageContentImage.SetNativeSize();
        }

        public void OnButtonBackClicked()
        {
            wikiPage.SetActive(false);
            Vector3 pos = wikiPageContentImage.gameObject.transform.localPosition;
            pos.y = 0;
            wikiPageContentImage.gameObject.transform.localPosition = pos;
            wikiPageContentImage.sprite = null;
        }
    }
}
