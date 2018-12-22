using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Client : MonoBehaviour {

	public Button PlayBtn;
	public Button PauseBtn;
	public Button StopBtn;
	public Video VideoInstance;
	public Audio AudioInstance;
	
	void Start () {
		PlayBtn.onClick.AddListener(PlayVideo);
		PauseBtn.onClick.AddListener(StopVideo);
		StopBtn.onClick.AddListener(StopVideo);
	}
	
	
	void Update () {
	
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
