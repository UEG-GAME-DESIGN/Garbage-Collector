/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: Mostrar recorde na cena recorde.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextoDoRecord : MonoBehaviour {
	
	Text txt;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Recorde: " + Record.RecordAtual + "\nPontos: " + Texto.pontosAuxiliar;
	}
}