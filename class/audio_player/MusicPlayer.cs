using Godot;



/// <summary>
/// 循环播放音频。<br/>
/// 非特殊情况应使用根节点中的实例播放音乐。
/// </summary>
[GlobalClass]
public partial class MusicPlayer : AudioStreamPlayer {
    // 构造器 //
    public MusicPlayer() {
        this.Finished += OnFinished;
    }



    // 导出变量 //
    [Export]
    bool Loop = true;



    // 信号方法 //
    private void OnFinished() {
        // 循环播放
        if (Loop) {
            Play();
        }
    }
}