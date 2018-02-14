using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class BotaoHeader : MonoBehaviour,IInputClickHandler,
IFocusable  {
   
    private MenuController menuController;

    private BotaoAnimation botaoAnimation;

    Animator animator;

    // Use this for initialization
    void Start () {
		//  defaultMaterials = GetComponent<Renderer>().materials;

        menuController = FindObjectOfType<MenuController>();
        botaoAnimation = GetComponentInChildren<BotaoAnimation>();
        animator = GetComponent<Animator>();
        // botaoAnimation.EntrouFocus();    
        
	}
	
	// Update is called once per frame
    void Update () {
		
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
    //  botaoAnimation.EntrouFocus();  
    animator.SetTrigger("highlight");
    }

    public void OnFocusExit()
    {
        animator.SetTrigger("idle");
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
