using System;
using UnityEngine;

namespace Data
{
    [Serializable]
    public class QuestionData
    {
        public string questionText;
        public Sprite questionImage;
        public AnswerOption[] answerOptions;
        public int correctAnswerIndex;
    }

    [Serializable]
    public class AnswerOption
    {
        public string answerText;
        public Sprite answerImage;
    }
}