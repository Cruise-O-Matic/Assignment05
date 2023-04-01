using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Reset : MonoBehaviour
{

    private void Awake()
    {
        WordDisplay.typedLetters = 0;
        WordDisplay.correctLetters = 0;
        WordSpawner.wordsUsed = 0;

    }
}
