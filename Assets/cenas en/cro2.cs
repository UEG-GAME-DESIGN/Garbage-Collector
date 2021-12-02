/*
autor:Nicolas Romario, Eduardo Henrique
data: 15/01/2015
objetivo: aparecer a pontuaçao, o cronometro, e monitorar o click
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cro2 : MonoBehaviour {
	
	Text txt;

	public int auxiliar;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Points: " + AuxPontos.pontos + "\nTime: " + (int)Texto.cronometro;

	}
}