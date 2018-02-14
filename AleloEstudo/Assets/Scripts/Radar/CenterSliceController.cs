using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class CenterSliceController : MonoBehaviour, IFocusable, IInputClickHandler {
	Animator animator;

	MenuController menuController;
	private RadarSliceController radarSliceController;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		radarSliceController =  GetComponentInParent<RadarSliceController>();
		menuController = GetComponent<MenuController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	   public void OnFocusEnter()
    {
		animator.SetTrigger("highlight");
		radarSliceController.EntrouCenterSlice(this.name);
		
    }

    public void OnFocusExit()
    {
		animator.SetTrigger("idle");
		radarSliceController.SaiuCenterSlice(this.name);
		
    }

		 public void OnInputClicked(InputClickedEventData eventData)
    {
       string quadrantName =  transform.parent.parent.parent.name + transform.parent.name ;
			menuController.HandleQuadrantSelection(quadrantName);
    }
}
