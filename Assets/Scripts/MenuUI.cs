using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Button startGameButton;

    private string playerName;

    void Start()
    {
        //nameInput = GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        SessionManager.Instance.playerName = playerName;
        SceneManager.LoadScene(1);
    }

    public void UpdatePlayerName()
    {
        playerName = nameInput.text;

        if (nameInput.text.Length > 3)
        {
            startGameButton.interactable = true;
        }
        else
        {
            startGameButton.interactable = false;
        }

    }
}
