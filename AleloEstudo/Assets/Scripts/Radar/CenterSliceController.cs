using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class CenterSliceController : MonoBehaviour, IFocusable, IInputClickHandler
{
	Animator animator;

    public GameObject Menu;
    MenuController menuController;

    public bool isCenterSliceON = false;

    void Start ()
    {
		animator = GetComponent<Animator>();
        menuController = Menu.GetComponent<MenuController>();
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
       string quadrantName =  transform.parent.parent.parent.name + transform.parent.name ;
			menuController.HandleQuadrantSelection(quadrantName);
    }

    void Update()
    {
        if (isCenterSliceON && Input.GetMouseButtonDown(0))
        {
            string contentToPrint = transform.parent.parent.parent.parent.name + this.gameObject.name;
            menuController.PrintContent(contentToPrint);
        }
    }
}
