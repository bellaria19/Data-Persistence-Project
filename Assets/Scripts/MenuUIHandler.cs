using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    private void Start()
    {
        PlayerPrefsManager.LoadHighScore();
        // playerNameInput.text = PlayerPrefsManager.LoadPlayerName();
    }

    public void StartNew()
    {
        PlayerPrefsManager.SavePlayerName(playerNameInput.text.Trim());
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        //Don't forget since this use editor code, need to add "using UnityEditor" at the top and wrap it between #if
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
