using System;

[Serializable]
public class InputEntry 
{
    public string playerName;
    public int playerScore;

    public  InputEntry(string name, int score)
    {
        playerName = name;
        playerScore = score;
    }
}
