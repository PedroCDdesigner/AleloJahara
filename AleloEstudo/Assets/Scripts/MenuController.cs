using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	// Use this for initialization

    private BotaoHeader[] botaoHeaders;

    private RadarTextController radarTextController;

    public string currentButton;

	void Start ()
    {
        MapComponents();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

	public void BotaoHeaderSelect(string name)
    {
        currentButton = name;
            foreach (BotaoHeader botao in botaoHeaders)
            {
                if (currentButton == botao.name)
                {
                    botao.ClearUnselectedButton(currentButton);
                }
        }
        //currentButton = name;
        
		switch (name)
        {
        case "Mobilidade":
            radarTextController.HandleHeaderButton(name);
            break;
        case "Restaurante":
            radarTextController.HandleHeaderButton(name);
            break;
        case "Saude":
            radarTextController.HandleHeaderButton(name);
            break;
        case "Logistica":
            radarTextController.HandleHeaderButton(name);
            break;
        case "Cultura":
            radarTextController.HandleHeaderButton(name);
            break;
        default:
            print ("DEU ERRADOOO");
            break;
		}
	}

    public void HandleQuadrantSelection(string name){
        switch (currentButton)
        {
        case "Mobilidade":
            print ("MobilidadeMobilidadeMobilidadeMobilidadeMobilidadeMobilidade");
            radarTextController.HandleHeaderButton(name);
            break;
        case "Restaurante":
            print ("RestauranteRestauranteRestauranteRestauranteRestaurante");
            radarTextController.HandleHeaderButton(name);
            break;
        case "Saude":
            print ("SaudeSaudeSaudeSaudeSaudeSaude");
            radarTextController.HandleHeaderButton(name);
            break;
        case "Logistica":
            print ("LogisticaLogisticaLogisticaLogistica!");
            radarTextController.HandleHeaderButton(name);
            break;
        case "Cultura":
            print ("CulturaCulturaCulturaCultura");
            radarTextController.HandleHeaderButton(name);
            break;
        default:
            print ("DEU ERRADOOO");
            break;
		}


    }

    public void PrintContent(string name)
    {
        string switchThis = currentButton + name;
        switch (switchThis)
        {
            case "MobilidadeQ00OutSlice":
                print(switchThis);
                break;
            case "MobilidadeQ01OutSlice":
                print(switchThis);
                break;
            case "MobilidadeQ02OutSlice":
                print(switchThis);
                break;
            case "MobilidadeQ03OutSlice":
                print(switchThis);
                break;
            case "MobilidadeQ04OutSlice":
                print(switchThis);
                break;
            case "MobilidadeQ05OutSlice":
                print(switchThis);
                break;
            case "MobilidadeQ00CenterSlice":
                print(switchThis);
                break;
            case "MobilidadeQ01CenterSlice":
                print(switchThis);
                break;
            case "MobilidadeQ02CenterSlice":
                print(switchThis);
                break;
            case "MobilidadeQ03CenterSlice":
                print(switchThis);
                break;
            case "MobilidadeQ04CenterSlice":
                print(switchThis);
                break;
            case "MobilidadeQ05CenterSlice":
                print(switchThis);
                break;
                //
            case "RestauranteQ00OutSlice":
                print(switchThis);
                break;
            case "RestauranteQ01OutSlice":
                print(switchThis);
                break;
            case "RestauranteQ02OutSlice":
                print(switchThis);
                break;
            case "RestauranteQ03OutSlice":
                print(switchThis);
                break;
            case "RestauranteQ04OutSlice":
                print(switchThis);
                break;
            case "RestauranteQ05OutSlice":
                print(switchThis);
                break;
            case "RestauranteQ00CenterSlice":
                print(switchThis);
                break;
            case "RestauranteQ01CenterSlice":
                print(switchThis);
                break;
            case "RestauranteQ02CenterSlice":
                print(switchThis);
                break;
            case "RestauranteQ03CenterSlice":
                print(switchThis);
                break;
            case "RestauranteQ04CenterSlice":
                print(switchThis);
                break;
            case "RestauranteQ05CenterSlice":
                print(switchThis);
                break;
            //
            case "SaudeQ00OutSlice":
                print(switchThis);
                break;
            case "SaudeQ01OutSlice":
                print(switchThis);
                break;
            case "SaudeQ02OutSlice":
                print(switchThis);
                break;
            case "SaudeQ03OutSlice":
                print(switchThis);
                break;
            case "SaudeQ04OutSlice":
                print(switchThis);
                break;
            case "SaudeQ05OutSlice":
                print(switchThis);
                break;
            case "SaudeQ00CenterSlice":
                print(switchThis);
                break;
            case "SaudeQ01CenterSlice":
                print(switchThis);
                break;
            case "SaudeQ02CenterSlice":
                print(switchThis);
                break;
            case "SaudeQ03CenterSlice":
                print(switchThis);
                break;
            case "SaudeQ04CenterSlice":
                print(switchThis);
                break;
            case "SaudeQ05CenterSlice":
                print(switchThis);
                break;
            //
            case "LogisticaQ00OutSlice":
                print(switchThis);
                break;
            case "LogisticaQ01OutSlice":
                print(switchThis);
                break;
            case "LogisticaQ02OutSlice":
                print(switchThis);
                break;
            case "LogisticaQ03OutSlice":
                print(switchThis);
                break;
            case "LogisticaQ04OutSlice":
                print(switchThis);
                break;
            case "LogisticaQ05OutSlice":
                print(switchThis);
                break;
            case "LogisticaQ00CenterSlice":
                print(switchThis);
                break;
            case "LogisticaQ01CenterSlice":
                print(switchThis);
                break;
            case "LogisticaQ02CenterSlice":
                print(switchThis);
                break;
            case "LogisticaQ03CenterSlice":
                print(switchThis);
                break;
            case "LogisticaQ04CenterSlice":
                print(switchThis);
                break;
            case "LogisticaQ05CenterSlice":
                print(switchThis);
                break;
            //
            case "CulturaQ00OutSlice":
                print(switchThis);
                break;
            case "CulturaQ01OutSlice":
                print(switchThis);
                break;
            case "CulturaQ02OutSlice":
                print(switchThis);
                break;
            case "CulturaQ03OutSlice":
                print(switchThis);
                break;
            case "CulturaQ04OutSlice":
                print(switchThis);
                break;
            case "CulturaQ05OutSlice":
                print(switchThis);
                break;
            case "CulturaQ00CenterSlice":
                print(switchThis);
                break;
            case "CulturaQ01CenterSlice":
                print(switchThis);
                break;
            case "CulturaQ02CenterSlice":
                print(switchThis);
                break;
            case "CulturaQ03CenterSlice":
                print(switchThis);
                break;
            case "CulturaQ04CenterSlice":
                print(switchThis);
                break;
            case "CulturaQ05CenterSlice":
                print(switchThis);
                break;
            //
            default:
                //Debug.Log(switchThis);
                break;
        }
    }

        private void MapComponents(){
        botaoHeaders = GetComponentsInChildren<BotaoHeader>();
        radarTextController = GetComponentInChildren<RadarTextController>();
    }
    
}
