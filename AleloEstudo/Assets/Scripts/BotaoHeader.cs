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

    public GameObject CirculoHeaderStart;
    public GameObject CirculoHeaderFinish;

    public bool isHighlited = false;
    public bool wasClicked = false;

    Animator animator;

    // Use this for initialization
    void Start () {
        //  defaultMaterials = GetComponent<Renderer>().materials;

        LHc = LinhaHeader.GetComponent<AnimatedLineRenderer>();
        LRc = LinhaRadar.GetComponent<AnimatedLineRenderer>();

        CirculoHeaderStart.SetActive(isHighlited);

        menuController = FindObjectOfType<MenuController>();
        botaoAnimation = GetComponentInChildren<BotaoAnimation>();
        animator = GetComponent<Animator>();

        // botaoAnimation.EntrouFocus();    
        
	}
	
	// Update is called once per frame
    void Update () {
        if (LHc.isLineFinished)
        {
            CirculoHeaderFinish.SetActive(true);
        }


        if (isHighlited && Input.GetMouseButtonDown(0))
        {
            menuController.BotaoHeaderSelect(this.name);
            animator.SetTrigger("selected");
            Debug.Log(menuController.currentButton);
        }


        Debug.Log(LHc.isLineFinished);
		
	}

    public void ClearUnselectedButton(string name){
        Debug.Log("NAME CHEGOU CLEAR" + name);
        if (name == this.name){
            animator.SetTrigger("selectedToHighlight");
            animator.SetTrigger("idle");
        }
        
    }


    public void OnFocusEnter()
    {
        isHighlited = true;
    //  botaoAnimation.EntrouFocus();  
        animator.SetTrigger("highlight");

        CirculoHeaderStart.SetActive(isHighlited);
        LHc.MapPoints();
        LHc.highlited = isHighlited;


        LRc.GetComponent<AnimatedLineRenderer>().MapPoints();
        LRc.GetComponent<AnimatedLineRenderer>().highlited = isHighlited;
    }

    public void OnFocusExit()
    {
        isHighlited = false;
        animator.SetTrigger("idle");

        CirculoHeaderStart.SetActive(isHighlited);
        LHc.Reset();
        LHc.highlited = isHighlited;

        LRc.Reset();
        LRc.highlited = isHighlited;
        // MoveOverSeconds(objectToMove, StartPosition.transform.position, Speed);
        //  Debug.Log("SAIU" + this.name);
    }


    public void OnInputClicked(InputClickedEventData eventData)
    {
        //   Debug.Log("CLICKKKKK" + this.name);
        menuController.BotaoHeaderSelect(this.name);
        animator.SetTrigger("selected");
    }

    

}
