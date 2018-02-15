using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	// Use this for initialization

    private BotaoHeader[] botaoHeaders;

    private RadarTextController radarTextController;

    public string currentButton = "Mobilidade";

	void Start () {
        MapComponents();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BotaoHeaderSelect(string name){
            foreach (BotaoHeader botao in botaoHeaders){
                if (currentButton == botao.name) {
                    botao.ClearUnselectedButton(currentButton);
                }
            }
        currentButton = name;
        
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

    private void MapComponents(){
        botaoHeaders = GetComponentsInChildren<BotaoHeader>();
        radarTextController = GetComponentInChildren<RadarTextController>();
    }
    
}
