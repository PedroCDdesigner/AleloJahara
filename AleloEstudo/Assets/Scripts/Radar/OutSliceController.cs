using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using DigitalRuby.AnimatedLineRenderer;

public class OutSliceController : MonoBehaviour, IFocusable, IInputClickHandler
{
    Animator animator;

    public GameObject Menu;
    MenuController menuController;

    public bool isOutSliceON = false;

    void Start()
    {
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
        if (isOutSliceON)
        {
            string contentToPrint = transform.parent.parent.parent.parent.name + this.gameObject.name;
            menuController.PrintContent(contentToPrint);
        }
    }

    //Only needed for MOUSE CLICK INPUT (can be deleted for hololens)
    void Update()
    {
        if (isOutSliceON && Input.GetMouseButtonDown(0))
        {
            string contentToPrint = transform.parent.parent.parent.parent.name + this.gameObject.name;
            menuController.PrintContent(contentToPrint);
        }
    }
}