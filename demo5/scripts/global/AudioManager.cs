using Godot;
using System;

public partial class AudioManager : Node
{
	private AudioStreamPlayer _audioPlayer;
	private float _volumeDb = 0.0f; // 默认音量（分贝）

	public override void _Ready()
	{
		// 创建一个 AudioStreamPlayer 节点并将其添加到当前节点
		_audioPlayer = new AudioStreamPlayer();
		AddChild(_audioPlayer);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// 播放背景音乐
	public void PlayBackgroundMusic(AudioStream audioStream)
	{
		// 如果当前正在播放，停止当前音乐
		if (_audioPlayer.Playing)
		{
			_audioPlayer.Stop();
		}
		// 设置新的音频流并播放
		_audioPlayer.Stream = audioStream;
		_audioPlayer.StreamPaused = false; // 确保播放时未暂停
		_audioPlayer.Play();
	}

	// 暂停播放
	public void PauseMusic()
	{
		if (_audioPlayer.Playing && !_audioPlayer.StreamPaused)
		{
			_audioPlayer.StreamPaused = true; // 暂停播放
		}
	}

	// 继续播放
	public void ResumeMusic()
	{
		if (_audioPlayer.StreamPaused)
		{
			_audioPlayer.StreamPaused = false; // 恢复播放
		}
	}

	//停止播放
	public void StopMusic()
	{
		if (_audioPlayer.Playing)
		{
			_audioPlayer.Stop();
		}
	}
	
	// 增大音量
	public void IncreaseVolume(float step = 1.0f)
	{
		_volumeDb = Mathf.Clamp(_volumeDb + step, -80.0f, 0.0f); // 限制音量范围
		_audioPlayer.VolumeDb = _volumeDb;
	}
	
	// 减小音量
	public void DecreaseVolume(float step = 1.0f)
	{
		_volumeDb = Mathf.Clamp(_volumeDb - step, -80.0f, 0.0f); // 限制音量范围
		_audioPlayer.VolumeDb = _volumeDb;
	}

    // 设置音量
    public void SetVolume(float volumeDb)
    {
        _volumeDb = Mathf.Clamp(volumeDb, -80.0f, 0.0f); // 限制音量范围
        _audioPlayer.VolumeDb = _volumeDb;
    }

    // 获取当前音量
    public float GetVolume()
    {
        return _volumeDb;
    }
}
