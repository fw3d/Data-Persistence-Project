using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderboardUI : MonoBehaviour
{
    [SerializeField] GameObject prefabsParent;
    [SerializeField] GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var InputEntry in SessionManager.Instance.entries.OrderByDescending(pl => pl.playerScore))
        {
            GameObject p = Instantiate(prefab, prefabsParent.transform);
            HighScoreUI code = p.GetComponent<HighScoreUI>();
            code.playerData = InputEntry;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
