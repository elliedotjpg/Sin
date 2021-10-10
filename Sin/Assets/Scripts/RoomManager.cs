

using UnityEngine.SceneManagement;

public static class RoomManager
{
    private static string lastLevel;

    public static void setLastLevel(string level)
    {
        lastLevel = level;
    }

    public static string getLastLevel()
    {
        return lastLevel;
    }

    public static void changeToPreviousLvl()
    {
        SceneManager.LoadScene(lastLevel);
    }
}