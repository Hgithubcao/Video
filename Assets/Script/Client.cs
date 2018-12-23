using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Client : MonoBehaviour {
	public Video VideoInstance;
	public Audio AudioInstance;
	public ButtonManager ButtonManagerInastance;
	public Client Instance;
	private int _week = 0;

	private void Awake()
	{
		Instance = this;
		ButtonManagerInastance.SetVideoPlayer(VideoInstance);
	}
}
