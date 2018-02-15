using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using DigitalRuby.AnimatedLineRenderer;

public class BotaoHeader : MonoBehaviour,IInputClickHandler,
IFocusable  {
   
    private MenuController menuController;
    private BotaoAnimation botaoAnimation;

    public GameObject LinhaHeader;
    private AnimatedLineRenderer LHc;

    public GameObject LinhaRadar;
    private AnimatedLineRenderer LRc;

    public GameObject CirculoHeaderFinish;

    private bool unMap = true;
    Animator animator;

    void Start ()
    {
        //  defaultMaterials = GetComponent<Renderer>().materials;

        LHc = LinhaHeader.GetComponent<AnimatedLineRenderer>();
        LRc = LinhaRadar.GetComponent<AnimatedLineRenderer>();

        menuController = FindObjectOfType<MenuController>();
        botaoAnimation = GetComponentInChildren<BotaoAnimation>();
        animator = GetComponent<Animator>();
	}
	
    void Update ()
    {
        if (animator.GetBool("isHighlighted") && Input.GetMouseButtonDown(0))
        {
            //Only maps line points if needed
            if(!LHc.isMapped && unMap)
            {
                LHc.MapPoints();
                LRc.MapPoints();
            }
            LRc.clicked = true;
            LHc.clicked = true;

            menuController.BotaoHeaderSelect(this.name);            

            animator.SetBool("isSelected", true);
        }

        //If you click on a new header button -- (Destroy old Lines), (Animator Updates), (Unmaps Lines)
        if (menuController.currentButton != this.name)
        {
            animator.SetBool("isSelected", false);
            LRc.clicked = false;
            LHc.clicked = false;

            //Unmap when you click a new button
            unMap = true;
                //Destroys Line
                LHc.Reset();
                LRc.Reset();
        }
	}

    public void OnFocusEnter()
    {
        animator.SetBool("isHighlighted", true);      
    }

    public void OnFocusExit()
    {
        animator.SetBool("isHighlighted", false);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        /*menuController.BotaoHeaderSelect(this.name);
        animator.SetTrigger("selected");*/

        if (animator.GetBool("isHighlighted"))
        {
            //Only maps if needed
            if (!LHc.isMapped && unMap)
            {
                LHc.MapPoints();
                LRc.MapPoints();
            }
            LRc.clicked = true;
            LHc.clicked = true;

            menuController.BotaoHeaderSelect(this.name);

            animator.SetBool("isSelected", true);
        }

        //If you click on a new header button -- (Destroy old Lines), (Animator Updates), (Unmaps Lines)
        if (menuController.currentButton != this.name)
        {
            animator.SetBool("isSelected", false);
            LRc.clicked = false;
            LHc.clicked = false;

            //Unmap when you click a new button
            unMap = true;
            //Destroys Line
            LHc.Reset();
            LRc.Reset();
        }
    }

    

}
