using TMPro;
using UnityEngine;

public class HighScoreUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerNameText;
    [SerializeField] TextMeshProUGUI playerScoreText;

    public InputEntry playerData;

    void Start()
    {
        playerNameText.text = playerData.playerName;
        playerScoreText.text = playerData.playerScore.ToString();
    }
}
