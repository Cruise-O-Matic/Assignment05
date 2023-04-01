using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class WordGenerator : MonoBehaviour
{
    // private static string[] wordList = {   "sidewalk", "robin", "three", "protect", "periodic",
    //                               "somber", "majestic", "jump", "pretty", "wound", "jazzy",
    //                               "memory", "join", "crack", "grade", "boot", "cloudy", "sick",
    //                               "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
    //                               "weird", "cut", "parallel", "wood", "encouraging", "interrupt",
    //                               "guide", "long", "chief", "mom", "signal", "rely", "abortive",
    //                               "hair", "representative", "earth", "grate", "proud", "feel",
    //                               "hilarious", "addition", "silent", "play", "floor", "numerous",
    //                               "friend", "pizzas", "building", "organic", "past", "mute", "unusual",
    //                               "mellow", "analyse", "crate", "homely", "protest", "painstaking",
    //                               "society", "head", "female", "eager", "heap", "dramatic", "present",
    //                               "sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
    //                               "boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
    //                               "account", "spot", "thought", "distinct", "nimble", "practise", "cream",
    //                               "ablaze", "thoughtless", "love", "verdict", "giant"    };


    [SerializeField] Text all_words;

    private static string[] wordList = new string[1000];
    string myFilePath, fileName;

    int i;

    void Start()
    {
        fileName = "RandomWords.txt";
        myFilePath = Application.dataPath + "/" + fileName;
        ReadFromTheFile();
    }

    void wordGet()
    {
        foreach (string line in wordList)
        {
            all_words.text += line + "\n";
        }

    }

    public void ReadFromTheFile()
    {
        wordList = File.ReadAllLines(myFilePath);
        wordGet();
    }


    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
