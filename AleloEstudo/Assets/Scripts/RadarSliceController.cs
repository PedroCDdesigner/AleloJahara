using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RadarSliceController : MonoBehaviour {

	Animator animator;

	private bool focusWhite = false;

	private bool focusCenterSlice = false;

	private bool focusOutSlice = false;

	
	
    // Use this for initialization
    void Start () {
		animator = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EntrouWhiteSlice(string name){
			focusWhite = true;
			animator.SetTrigger("highlightWhite");
	}



	public void SaiuWhiteSlice(string name){
			focusWhite = false;
			

	}
	
	public void EntrouCenterSlice(string name){
			focusCenterSlice = true;
	}

	public void SaiuCenterSlice(string name){
			focusCenterSlice = false;
			Invoke("VerificarFocus", 0.1f);

	}

	public void EntrouOutSlice(string name){
			focusOutSlice = true;
	}

	public void SaiuOutSlice(string name){
			focusOutSlice = false;
			Invoke("VerificarFocus", 0.1f);
	}

	private void VerificarFocus(){
			if (!focusOutSlice && !focusCenterSlice){
				animator.SetTrigger("idle");
			}
	}



	

	




}
