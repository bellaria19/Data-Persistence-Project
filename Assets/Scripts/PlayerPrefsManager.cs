using UnityEngine;

public static class PlayerPrefsManager
{
    private const string PlayerNameKey = "PlayerName";
    private const string HighScoreNameKey = "HighScoreName";
    private const string HighScoreKey = "HighScore";

    public static string PlayerName { get; private set; }
    public static string HighScoreName { get; private set; }
    public static int HighScore { get; private set; }

    public static void LoadHighScore()
    {
        HighScoreName = PlayerPrefs.GetString(HighScoreNameKey, "");
        HighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
    }

    public static bool CheckHighScore(string playername, int score)
    {
        if (score <= HighScore)
        {
            return false;
        }

        HighScoreName = playername;
        HighScore = score;

        PlayerPrefs.SetString(HighScoreNameKey, HighScoreName);
        PlayerPrefs.SetInt(HighScoreKey, HighScore);
        PlayerPrefs.Save();

        return true;
    }

    public static void SavePlayerName(string playerName)
    {
        PlayerName = playerName;
        PlayerPrefs.SetString(PlayerNameKey, playerName);
        PlayerPrefs.Save();
    }

    public static string LoadPlayerName()
    {
        return PlayerPrefs.GetString(PlayerNameKey, string.Empty);
    }
}
