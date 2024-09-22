using System;
using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class SessionManager : MonoBehaviour
{
    public static SessionManager Instance;

    public string playerName;
    public int playerScore;

    [SerializeField] string fileName;
    

    public List<InputEntry> entries = new List<InputEntry> ();

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        entries = FileHandler.ReadFromJSON<InputEntry>(fileName);
    }
    
    public void AddNewHighScore(int score)
    {
        entries.Add (new InputEntry(playerName, score));
        FileHandler.SaveToJSON<InputEntry>(entries, fileName);
    }


    public void LoadHighScore()
    {

    }
}
