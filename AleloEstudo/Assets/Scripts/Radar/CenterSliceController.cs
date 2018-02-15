using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using DigitalRuby.AnimatedLineRenderer;

public class CenterSliceController : MonoBehaviour, IFocusable, IInputClickHandler
{
	Animator animator;

    public GameObject Menu;
    MenuController menuController;

    public bool isCenterSliceON = false;

    public GameObject Linha_RadarContent;
    private AnimatedLineRenderer LRadC;

    public GameObject Linha_Flutua_RadarContent;
    private AnimatedLineRenderer LFlutC;

    private bool unMap = true;

    void Start ()
    {
		animator = GetComponent<Animator>();
        menuController = Menu.GetComponent<MenuController>();

        LRadC = Linha_RadarContent.GetComponent<AnimatedLineRenderer>();
        LFlutC = Linha_Flutua_RadarContent.GetComponent<AnimatedLineRenderer>();
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
        if (isCenterSliceON)
        {
            string contentToPrint = transform.parent.parent.parent.parent.name + this.gameObject.name;
            menuController.PrintContent(contentToPrint);
        }
    }

    //Only needed for MOUSE CLICK INPUT (can be deleted for hololens)
    void Update()
    {
        if (isCenterSliceON && Input.GetMouseButtonDown(0) && menuController.currentButton != null)
        {
            string contentToPrint = transform.parent.parent.parent.parent.name + this.gameObject.name;
            menuController.PrintContent(contentToPrint);

            //Only maps line points if needed
            if (!LRadC.isMapped && unMap)
            {
                LFlutC.MapPoints();
                LRadC.MapPoints();
            }
            LFlutC.clicked = true;
            LRadC.clicked = true;
        }
    }
}
