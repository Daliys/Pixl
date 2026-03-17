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
            Sprite sprite = wikiCards.models[index - 1].theoryContent.GetSpriteByLanguage(LocalizationManager.GetCurrentLanguage());
            wikiPageContentImage.sprite = sprite;
            wikiPageContentImage.preserveAspect = true;
            wikiPageContentImage.SetNativeSize();

            RectTransform rect = wikiPageContentImage.rectTransform;
            // Set anchors to Top-Stretch
            rect.anchorMin = new Vector2(0, 1);
            rect.anchorMax = new Vector2(1, 1);
            rect.pivot = new Vector2(0.5f, 1);

            // Calculate height based on parent width to maintain aspect ratio with Left/Right 0
            float parentWidth = ((RectTransform)rect.parent).rect.width;
            float ratio = sprite.rect.height / sprite.rect.width;
            float targetHeight = parentWidth * ratio;

            // Set sizeDelta (x=0 means stretch to anchors, y=calculated height)
            rect.sizeDelta = new Vector2(0, targetHeight);
            rect.anchoredPosition = Vector2.zero;
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
