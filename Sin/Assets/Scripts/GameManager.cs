public class GameManager
{
    public enum EnumGameState
    {
        Playing,
        Freeze,
        GameOver
    }

    public static EnumGameState GameState { get; set; }
}
