using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ConteudoController : MonoBehaviour {

	private VideoPlayer videoPlayer;

	// Use this for initialization
	void Start () {
		videoPlayer = GetComponentInChildren<VideoPlayer>();
		videoPlayer.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleCounteudoSelection(string conteudo, string quadrant)
	{
		
	}
}
