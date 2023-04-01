using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text LetterText;

    private int wordsMade = WordSpawner.wordsUsed;
    public Text WordsUsedText;

    public Text CorrectLettersText;
    public Text PercentText;
    private float correctPercent;


    void CalculatePercent()
    {
        int numLetters = WordDisplay.typedLetters;
        float numLetters2 = (float)numLetters;
        int numCorrect = WordDisplay.correctLetters;
        float numCorrect2 = (float)numCorrect;
        correctPercent = numCorrect2 / numLetters2 * 100;
    }

    void Start()
    {
        CalculatePercent();

        LetterText.text = "Letters typed: " + WordDisplay.typedLetters.ToString();

        WordsUsedText.text = "Number of words used: " + wordsMade.ToString();

        CorrectLettersText.text = "Letters typed correctly: " + WordDisplay.correctLetters.ToString();

        var result = correctPercent.ToString("F0");
        PercentText.text = "Typed correctly: " + result + "%";
    }


}
