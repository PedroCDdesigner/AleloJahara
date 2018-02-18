using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ConteudoController : MonoBehaviour {

	private VideoPlayer videoPlayer;
	private AudioSource audioSource;

	// Use this for initialization

	void Awake() {
			videoPlayer = GetComponentInChildren<VideoPlayer>();
			audioSource = GetComponentInChildren<AudioSource>();
	}
	void Start () {
	
		
		
	}

	void OnEnable(){
		if (audioSource){
			audioSource.Play();
		}
		
		if (videoPlayer){
			videoPlayer.Play();
		}
		
	}

	void OnDisable(){
		if (audioSource){
			audioSource.Stop();
		}
		if (videoPlayer){
			videoPlayer.Stop();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleCounteudoSelection(string conteudo, string quadrant)
	{
		
	}
}
