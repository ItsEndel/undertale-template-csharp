using System.Collections.Generic;
using Godot;



[GlobalClass]
public partial class Scene : Node {
    // 节点信号 //

    /// <summary>
    /// 场景退出时触发。
    /// </summary>
    [Signal]
    public delegate void ExitedEventHandler();

    /// <summary>
    /// 场景进入时触发。
    /// </summary>
    [Signal]
    public delegate void EnteredEventHandler();



    // 功能方法 //

    /// <summary>
    /// 退出场景时向下一个房间传递数据。
    /// </summary>
    /// <returns>传递的数据。</returns>
    public virtual List<SceneData> Exit() { return new(); }

    /// <summary>
    /// 接收上一个房间传递的数据。
    /// </summary>
    /// <param name="data"></param>
    public virtual void Enter(List<SceneData> data) {}
}
