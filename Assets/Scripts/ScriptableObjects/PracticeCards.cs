using Data.CardsModel;
using Unity.VisualScripting;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "PracticeCards", menuName = "Custom/PracticeCards")]
    public class PracticeCards : ScriptableObject
    {
        [Serialize]
        public CardModelPractice[] models;
    }
}