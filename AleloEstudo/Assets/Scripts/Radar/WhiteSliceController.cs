using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class WhiteSliceController : MonoBehaviour, IFocusable {


    private RadarController radarController;

    public GameObject OutSlice;
    private OutSliceController OutSliceController;

    public GameObject CenterSlice;
    private CenterSliceController CenterSliceController;

    public bool isWhiteSliceOn;

    private Animator Anim;

    void Start ()
    {
        radarController = FindObjectOfType<RadarController>();
        Anim = GetComponent<Animator>();
        CenterSliceController = CenterSlice.GetComponent<CenterSliceController>();
        OutSliceController = OutSlice.GetComponent<OutSliceController>();
        MenuController.OnClicked += ResetAllSlices;
    }

	public void OnFocusEnter()
    {
        isWhiteSliceOn = true;
    }

    //Manages animation on Update
    private void Update()
    {
        if (OutSliceController.isOutSliceON || CenterSliceController.isCenterSliceON || isWhiteSliceOn || radarController.getquadrantName() == transform.parent.name)
        {
            Anim.SetBool("b_highlightWhite", true);
        }       else
                    {
                        Anim.SetBool("b_highlightWhite", false);
                    }

    }

    public void OnFocusExit()
    {
        isWhiteSliceOn = false;
    }

    public void ResetAllSlices()
    {
        isWhiteSliceOn = false;
        Anim.SetBool("b_highlightWhite", false);
        radarController.setquadrantName("Resetando");
    }

}


