using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoButtons : MonoBehaviour {

	public Button PlayBtn;
	public Button PauseBtn;
	public Button StopBtn;

	private Video videoPlayer;

	void Start()
	{
		PlayBtn.onClick.AddListener(PlayVideo);
		PauseBtn.onClick.AddListener(StopVideo);
		StopBtn.onClick.AddListener(StopVideo);
	}


	void Update()
	{

	}

	public void SetVideoPlayer(Video videoPlayer)
	{
		videoPlayer = videoPlayer;
	}

	void PlayVideo()
	{
	}

	void PauseVideo()
	{

	}

	void StopVideo()
	{

	}
}
