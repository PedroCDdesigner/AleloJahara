using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using DigitalRuby.AnimatedLineRenderer;

public class CenterSliceController : MonoBehaviour, IFocusable, IInputClickHandler
{


    private RadarController radarController;
   
    public string contentToPrint;

    public GameObject Menu;
    MenuController menuController;

    public bool isCenterSliceON = false;

    public Animator animator;

    void Start()
    {
        radarController = FindObjectOfType<RadarController>();
        animator = GetComponent<Animator>();
        menuController = Menu.GetComponent<MenuController>();

        //ASSIGNT METHOD TO ButtonHeader EVENT
        MenuController.OnClicked += ResetAllSlices;
    }

    public void OnFocusEnter()
    {
        isCenterSliceON = true;
        animator.SetBool("b_highCenter", true);
    }

    public void OnFocusExit()
    {
            isCenterSliceON = false;
            animator.SetBool("b_highCenter", false);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        /*string quadrantName =  transform.parent.parent.parent.name + transform.parent.name ;
             menuController.HandleQuadrantSelection(quadrantName);
        */
        if (isCenterSliceON && menuController.currentButton != null)
        {
            animator.SetBool("b_isClicked", true);
            radarController.setquadrantName(transform.parent.parent.parent.parent.name);
            //Debug.Log(quadrantName);
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
        if (isCenterSliceON && Input.GetMouseButtonDown(0) && menuController.currentButton != null)
        {
            animator.SetBool("b_isClicked", true);
            radarController.setquadrantName(transform.parent.parent.parent.parent.name);
            //Debug.Log(quadrantName);
            contentToPrint = radarController.getquadrantName() + this.gameObject.name;
            menuController.PrintContent(contentToPrint);

            //Used to store which button was selected
            radarController.SliceSelect(contentToPrint);


        }
        //Removes the "Clicked State" when you click another Slice
        if (radarController.getCurrentSlice() != contentToPrint)
        {
            animator.SetBool("b_isClicked", false);
            MenuController.OnClicked -= ResetAllSlices;
        }
    }

    //Method is invoked when any the BotaoHeaderSelect(string name) method is called on MenuController.cs
    public void ResetAllSlices()
    {
        animator.SetBool("b_isClicked", false);
    }


}
