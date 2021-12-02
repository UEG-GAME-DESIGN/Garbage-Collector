/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer texto do botão voltar ao "menu"
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class _voltar : MonoBehaviour {

	private Text txt;

	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Voltar ao menu";
		
	}
}
