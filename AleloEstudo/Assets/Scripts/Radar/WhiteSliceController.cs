using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class WhiteSliceController : MonoBehaviour, IFocusable {

	private RadarSliceController radarSliceController;
	// Use this for initialization
	void Start () {
		radarSliceController =  GetComponentInParent<RadarSliceController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	   public void OnFocusEnter()
    {
		radarSliceController.EntrouWhiteSlice(this.name);
		
    }

    public void OnFocusExit()
    {
		
		radarSliceController.SaiuWhiteSlice(this.name);
		
    }

	
}
