using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsandAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    public UnityEngine.UI.Text QuestionTxt; 
    public UnityEngine.UI.Text ScoreTxt; 

    int TotalQuestions = 0;
    public int score;

    private void Start()
    {
        TotalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + TotalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
       
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            
       
    }
}
