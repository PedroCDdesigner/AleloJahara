using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class WhiteSliceController : MonoBehaviour, IFocusable {

	private Animator Anim;
    
    public GameObject OutSlice;
    private OutSliceController OutSliceController;

    public GameObject CenterSlice;
    private CenterSliceController CenterSliceController;

    public bool isWhiteSliceOn;

    void Start ()
    {
        Anim = GetComponent<Animator>();
        CenterSliceController = CenterSlice.GetComponent<CenterSliceController>();
        OutSliceController = OutSlice.GetComponent<OutSliceController>();
    }

	public void OnFocusEnter()
    {
        isWhiteSliceOn = true;
    }

    //Manages animation on Update
    private void Update()
    {
        if (OutSliceController.isOutSliceON || CenterSliceController.isCenterSliceON || isWhiteSliceOn)
        {
            Anim.SetBool("b_highlightWhite", true);
        }       else
                      { Anim.SetBool("b_highlightWhite", false); }
    }

    public void OnFocusExit()
    {
        isWhiteSliceOn = false;
    }
}
