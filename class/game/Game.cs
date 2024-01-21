


/// <summary>
/// 游戏全局类。
/// </summary>
public class Game {
    // 静态单例 //
    public static Game SINGLETON { get; private set; } = new Game();



    // 功能变量 //

    /// <summary>
    /// 游戏根节点。
    /// </summary>
    public Root Root;
}
