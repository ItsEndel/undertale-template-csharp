using Godot;



/// <summary>
/// 指定位置播放单次音频。<br/>
/// 播放完成后自动释放。
/// </summary>
[GlobalClass]
public partial class SoundPlayer2D : AudioStreamPlayer2D {
    // 构造器 //
    public SoundPlayer2D() {
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
