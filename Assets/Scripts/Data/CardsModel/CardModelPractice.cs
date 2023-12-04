using System;
using ScriptableObjects;
using UnityEngine;

namespace Data.CardsModel
{
    [Serializable]
    public class CardModelPractice : CardModel
    {
        public GameObject levelPrefab;
        public TheoryContent theoryContent;
    }
}