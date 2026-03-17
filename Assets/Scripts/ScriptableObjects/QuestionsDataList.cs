using Data;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "QuestionsData", menuName = "Custom/Question Data")]
    public class QuestionsDataList : ScriptableObject
    {
        [SerializeField]
        public QuestionData[] questions;
    }
}