public class GameManager
{
    public enum EnumGameState
    {
        Playing,
        GameOver
    }

    public static EnumGameState GameState { get; set; }
}
