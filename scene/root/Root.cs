using Godot;
using System.Collections.Generic;

public partial class Root : Node
{
	// 导出变量 //
	
	/// <summary>
	/// 游戏启动时加载的场景。
	/// </summary>
	[Export]
	public PackedScene InitialScene;

	/// <summary>
	/// 音乐播放器节点。
	/// </summary>
	[Export]
	public MusicPlayer MusicPlayer;



	// 功能变量 //

	/// <summary>
	/// 游戏主场景。
	/// </summary>
	public Scene Scene {
		get => _scene;
		set => SetScene(value);
	}
	private Scene _scene;

	/// <summary>
	/// 音乐播放器。
	/// </summary>
	public MusicPlayer Music { get; private set; }



    // 节点方法 //
    public override void _Ready()
    {
        // 获取功能节点
		Music = MusicPlayer;

		// 设置全局变量
		Game.SINGLETON.Root = this;

		// 加载初始场景
		if (InitialScene != null) {
			Scene initScene = InitialScene.InstantiateOrNull<Scene>();

			if (initScene == null) {
				GD.PushError(InitialScene.ResourcePath, " is not Scene.");
			} else {
				Scene = initScene;
			}
		}
    }



    // 功能方法 //

    /// <summary>
    /// 设置游戏主场景。
    /// </summary>
    /// <param name="scene">游戏主场景。</param>
    public void SetScene(Scene scene) {
		List<SceneData> data = _scene.Exit();

		_scene.QueueFree();
		_scene = null;

		if (scene == null) {
			return;
		}

		scene.Enter(data);
		
		AddChild(scene);
		_scene = scene;
	}
}
