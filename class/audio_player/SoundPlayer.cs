using Godot;



/// <summary>
/// 播放单次音频。<br/>
/// 播放完成后自动释放。
/// </summary>
[GlobalClass]
public partial class SoundPlayer : AudioStreamPlayer {
    // 构造器 //
    public SoundPlayer() {
        // 连接信号
        this.Finished += OnFinished;
    }



    // 导出变量 //
    [Export]
    bool AutoFree = true;



    // 信号方法 //
    private void OnFinished() {
        // 自动释放
        if (AutoFree) {
            QueueFree();
        }
    }
}
