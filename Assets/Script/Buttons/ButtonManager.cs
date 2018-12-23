using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {
	public VideoButtons VideoButtonsInstance;
	public WeekButtons WeekButtonsInstance;

	public void SetVideoPlayer(Video videoPlayer)
	{
		VideoButtonsInstance.SetVideoPlayer(videoPlayer);
		WeekButtonsInstance.SetVideoPlayer(videoPlayer);
	}
}
