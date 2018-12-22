using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

// 对VideoPlayer的封装，支持UGUI的RawImage播放，支持结束事件
public class Video : MonoBehaviour
{
	[SerializeField] private VideoPlayer _videoPlayer;
	[SerializeField] private RawImage _imageVideo;

	private RenderTexture _renderTexture;
	private bool _isPlaying = false;

	private VideoPlayer.EventHandler onPrepareCompleted;

	public class VideoPlayerEvent : UnityEvent
	{
	}

	// 视频播放完毕的事件
	private VideoPlayerEvent m_OnFinish;
	public VideoPlayerEvent onFinish
	{
		get
		{
			if (m_OnFinish == null)
			{
				m_OnFinish = new VideoPlayerEvent();
			}
			return m_OnFinish;
		}
	}


	void Awake()
	{
		_renderTexture = new RenderTexture(Screen.width, Screen.height, 0);
		_videoPlayer.targetTexture = _renderTexture;
		_imageVideo.texture = _renderTexture;
	}

	void OnDestroy()
	{
		if (onPrepareCompleted != null)
		{
			_videoPlayer.prepareCompleted -= onPrepareCompleted;
			onPrepareCompleted = null;
		}

		_videoPlayer.Stop();

		// 清理掉创建rt
		Destroy(_renderTexture);
	}

	public void SetPrepareCompleted(Action callback)
	{
		if (callback != null)
		{
			onPrepareCompleted = (video) =>
			{
				callback();
			};
			_videoPlayer.prepareCompleted += onPrepareCompleted;
		}
	}

	// 播放
	public void Play(string path)
	{
		_videoPlayer.url = Application.streamingAssetsPath + "/" + path;
		_videoPlayer.Play();
	}

	// 暂停
	public void Pause()
	{
		_videoPlayer.Pause();
	}

	// 停止播放
	public void Stop()
	{
		_videoPlayer.Stop();
	}

	// 快进
	public void StepForward()
	{
		_videoPlayer.StepForward();
	}

	void Update()
	{
		if (_videoPlayer == null) return;

		if (_videoPlayer.isPlaying)
		{
			_isPlaying = true;
		}

		// 判定动画播放完毕
		if (_isPlaying && !_videoPlayer.isPlaying)
		{
			_isPlaying = false;

			if (m_OnFinish != null)
			{
				m_OnFinish.Invoke();
			}
		}
	}
}
