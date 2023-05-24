using Data.CardsModel;
using Unity.VisualScripting;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "TestCards", menuName = "Custom/Test Cards")]
    public class TestCards : ScriptableObject
    {
        [Serialize]
        public CardModelTest[] models;
    }
}