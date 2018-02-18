using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using DigitalRuby.AnimatedLineRenderer;

public class OutSliceController : MonoBehaviour, IFocusable, IInputClickHandler
{
    private RadarController radarController;

    public GameObject Menu;
    MenuController menuController;

    public string contentToPrint;

    public bool isOutSliceON = false;

    Animator animator;

    void Start()
    {
        radarController = FindObjectOfType<RadarController>();
        animator = GetComponent<Animator>();
        menuController = Menu.GetComponent<MenuController>();
    }

    public void OnFocusEnter()
    {
        isOutSliceON = true;
        animator.SetBool("b_highlightedOutSlice", true);
    }

    public void OnFocusExit()
    {
        isOutSliceON = false;
        animator.SetBool("b_highlightedOutSlice", false);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        /*string quadrantName = transform.parent.parent.parent.name + transform.parent.name ;
		menuController.HandleQuadrantSelection(quadrantName);*/
        if (isOutSliceON && menuController.currentButton != null)
        {
            animator.SetBool("b_isClicked", true);
            radarController.setquadrantName(transform.parent.parent.parent.parent.name);
            contentToPrint = radarController.getquadrantName() + this.gameObject.name;
            menuController.PrintContent(contentToPrint);

            //Used to store which button was selected
            radarController.SliceSelect(contentToPrint);
        }

        //Removes the "Clicked State" when you click another Slice
        if (radarController.getCurrentSlice() != contentToPrint)
        {
            animator.SetBool("b_isClicked", false);
        }
    }

    //Only needed for MOUSE CLICK INPUT (can be deleted for hololens)
    void Update()
    {
        if (isOutSliceON && Input.GetMouseButtonDown(0) && menuController.currentButton != null)
        {
            animator.SetBool("b_isClicked", true);
            radarController.setquadrantName(transform.parent.parent.parent.parent.name);
            //Debug.Log(quadrantName); //Debug
            contentToPrint = radarController.getquadrantName() + this.gameObject.name;
            menuController.PrintContent(contentToPrint);

            //Used to store which button was selected
            radarController.SliceSelect(contentToPrint);
        }
        //Removes the "Clicked State" when you click another Slice
        if (radarController.getCurrentSlice() != contentToPrint)
        {
            animator.SetBool("b_isClicked", false);
        }
    }
}