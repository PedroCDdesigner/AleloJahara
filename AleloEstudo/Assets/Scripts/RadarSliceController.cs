using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RadarSliceController : MonoBehaviour {

	Animator animator;

	private bool focusWhite = false;
	private bool focusCenterSlice = false;
	private bool focusOutSlice = false;

    void Start ()
    {
		animator = GetComponent<Animator>();	
	}

    private void Update()
    {
        
    }
    public void EntrouWhiteSlice(string name)
    {
		focusWhite = true;
        //animator.SetTrigger("highlightWhite");
        animator.SetBool("b_highlightWhite", true);
    }
    
	public void SaiuWhiteSlice(string name)
    {
			focusWhite = false;
            animator.SetBool("b_highlightWhite", false);
    }
	
	public void EntrouCenterSlice(string name)
    {
			focusCenterSlice = true;
	}

	public void SaiuCenterSlice(string name)
    {
			focusCenterSlice = false;
			Invoke("VerificarFocus", 0.1f);
	}

	public void EntrouOutSlice(string name)
    {
			focusOutSlice = true;
	}

	public void SaiuOutSlice(string name)
    {
			focusOutSlice = false;
			Invoke("VerificarFocus", 0.1f);
	}

	private void VerificarFocus()
    {
			if (!focusOutSlice && !focusCenterSlice)
            {
				animator.SetTrigger("idle");
			}
	}



	

	




}
