using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    #region Singleton
    public static GameManeger instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion
    Quiz.Dificulty difficulty;
    Quiz.Theme theme;
    QuizManager quizManager;
    private void Start()
    {
        quizManager = FindAnyObjectByType<QuizManager>();

    }
    public void startGame(int difficultyselected,int ts)
    {
        UIManager.instance.SetMenu(false);
        difficulty = (Quiz.Dificulty)difficultyselected;
        theme = (Quiz.Theme)ts;
        quizManager.SelectQuiz(theme,difficulty);
    }
}
