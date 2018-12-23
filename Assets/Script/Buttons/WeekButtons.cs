using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekButtons : MonoBehaviour {
	public Button[] weekButtonList;
	private Video _videoPlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetVideoPlayer(Video videoPlayer)
	{
		_videoPlayer = videoPlayer;
	}
}
