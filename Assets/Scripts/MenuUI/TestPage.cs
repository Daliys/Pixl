using System.Collections.Generic;
using Data;
using ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MenuUI
{
    public class TestPage : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI currentIndexText;
        [SerializeField] private TextMeshProUGUI totalIndexText;
        
        [SerializeField] private TextMeshProUGUI questionText;
        [SerializeField] private Image questionImage;

        [SerializeField] private TestAnswerButton button1;
        [SerializeField] private TestAnswerButton button2;
        [SerializeField] private TestAnswerButton button3;

        [SerializeField] private GameObject nextButton;
        [SerializeField] private TextMeshProUGUI nextButtonText;

        [SerializeField] private Color correctButtonColor;
        [SerializeField] private Color wrongButtonColor;

        [SerializeField] private GameObject resultPanel;
        [SerializeField] private TextMeshProUGUI resultCorrectText;
        [SerializeField] private TextMeshProUGUI resultWrongText;

        private int correctAnswers; 
        private int wrongAnswers; 
        
        private QuestionsDataList questionsDataList;
        private QuestionData[] randomSortedQuestions;
        private int currentIndex;

        private bool isTestFinished;

        public void Initialize(QuestionsDataList questionsDataList)
        {
            this.questionsDataList = questionsDataList;
            
            List<QuestionData> temp = new List<QuestionData>();
            temp.AddRange(this.questionsDataList.questions);

            randomSortedQuestions = new QuestionData[temp.Count];
            
            for (int i = 0; i < randomSortedQuestions.Length; i++)
            {
                int randomIndex = Random.Range(0, temp.Count);
                randomSortedQuestions[i] = temp[randomIndex];
                temp.RemoveAt(randomIndex);
            }
            
            button1.Initialize(OnButtonClicked);
            button2.Initialize(OnButtonClicked);
            button3.Initialize(OnButtonClicked);
            nextButton.SetActive(false);
            currentIndex = 0;
            correctAnswers = 0;
            wrongAnswers = 0;
            isTestFinished = false;
            
            resultPanel.gameObject.SetActive(false);
            nextButton.SetActive(false);
            ResetButtons();
            InitializeQuestion(randomSortedQuestions[currentIndex]);
        }

        private void InitializeQuestion(QuestionData questionData)
        {
            currentIndexText.text = (currentIndex+1).ToString("D2");
            totalIndexText.text = "/ " + randomSortedQuestions.Length;

            if (string.IsNullOrEmpty(questionData.questionText)) questionText.gameObject.SetActive(false);
            else
            {
                questionText.gameObject.SetActive(true);
                questionText.text = questionData.questionText;
            }
            
            if (questionData.questionImage == null) questionImage.gameObject.SetActive(false);
            else
            {
                questionImage.gameObject.SetActive(true);
                questionImage.sprite = questionData.questionImage;
                questionImage.preserveAspect = true;
            }

            
            if (questionData.answerOptions[0].answerImage == null) button1.SetButtonValue(questionData.answerOptions[0].answerText);
            else button1.SetButtonValue(questionData.answerOptions[0].answerImage);
            
            if (questionData.answerOptions[1].answerImage == null) button2.SetButtonValue(questionData.answerOptions[1].answerText);
            else button2.SetButtonValue(questionData.answerOptions[1].answerImage);
            
            if (questionData.answerOptions[2].answerImage == null) button3.SetButtonValue(questionData.answerOptions[2].answerText);
            else button3.SetButtonValue(questionData.answerOptions[2].answerImage);
        }

        private void OnButtonClicked(int index)
        {
            int correctIndex = randomSortedQuestions[currentIndex].correctAnswerIndex;
            if (correctIndex == index)
            {
                GetButton(index).gameObject.GetComponent<Image>().color = correctButtonColor;
                correctAnswers++;
            }
            else
            {
                GetButton(index).gameObject.GetComponent<Image>().color = wrongButtonColor;
                GetButton(correctIndex).gameObject.GetComponent<Image>().color = correctButtonColor;
                wrongAnswers++;
            }
            
            button1.gameObject.GetComponent<Button>().enabled = false;
            button2.gameObject.GetComponent<Button>().enabled = false;
            button3.gameObject.GetComponent<Button>().enabled = false;
            nextButton.SetActive(true);

            nextButtonText.text = (currentIndex+1) != randomSortedQuestions.Length ? "следующий вопрос" : "результат";
        }

        public void OnButtonNextClicked()
        {

            if (isTestFinished)
            {
                Initialize(questionsDataList);
                return;
            }
            
            if (currentIndex + 1 == randomSortedQuestions.Length)
            {
                resultPanel.gameObject.SetActive(true);
                resultCorrectText.text = correctAnswers.ToString();
                resultWrongText.text = wrongAnswers.ToString();
                nextButtonText.text = "повторить тест";
                isTestFinished = true;
                return;
            }
            
            currentIndex++;
            InitializeQuestion(randomSortedQuestions[currentIndex]);
            ResetButtons();
            nextButton.SetActive(false);
        }


        private void ResetButtons()
        {
            button1.gameObject.GetComponent<Image>().color = Color.white;
            button2.gameObject.GetComponent<Image>().color = Color.white;
            button3.gameObject.GetComponent<Image>().color = Color.white;

            button1.gameObject.GetComponent<Button>().enabled = true;
            button2.gameObject.GetComponent<Button>().enabled = true;
            button3.gameObject.GetComponent<Button>().enabled = true;
        }
         

        private TestAnswerButton GetButton(int index)
        {
            switch (index)
            {
                case 0: return button1;
                case 1: return button2;
                case 2: return button3;
            }

            return null;
        }
        
    }
}