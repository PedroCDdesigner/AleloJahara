using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarTextController : MonoBehaviour {

	GameObject mobilidade;
	GameObject restaurante;
	GameObject saude;
	GameObject logistica;
	GameObject cultura;


	// Use this for initialization
	void Start () {
		MapComponents();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleHeaderButton(string name){
		HideAll();
		switch (name)
        {
        case "Mobilidade":
			mobilidade.SetActive(true);
            break;
        case "Restaurante":
			restaurante.SetActive(true);
            break;
        case "Saude":
			saude.SetActive(true);
            break;
        case "Logistica":
			logistica.SetActive(true);
            break;
        case "Cultura":
			cultura.SetActive(true);
            break;
        default:
            print ("DEU ERRADOOO");
            break;
		}
	}

	private void MapComponents(){
		mobilidade = transform.Find("Mobilidade").gameObject;
		restaurante = transform.Find("Restaurante").gameObject;
		saude = transform.Find("Saude").gameObject;
		logistica = transform.Find("Logistica").gameObject;
		cultura = transform.Find("Cultura").gameObject;

	}

	private void HideAll(){
		mobilidade.SetActive(false);
		restaurante.SetActive(false);
		saude.SetActive(false);
		logistica.SetActive(false);
		cultura.SetActive(false);
	}
}
