using System;
using Localization;
using UnityEngine;

namespace Data.CardsModel
{
    [Serializable]
    public class CardModelWiki : CardModel
    {
        public LocalizationsIds description;
        public Sprite sprite;
    }
}