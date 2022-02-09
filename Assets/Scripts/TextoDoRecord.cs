/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: Mostrar recorde na cena recorde.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class TextoDoRecord : MonoBehaviour {
	
	public TMP_Text txt;
	
	// Use this for initialization
	void Start () {
		//txt = gameObject.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        txt.text = /*"Recorde: " +*/ Record.RecordAtual.ToString();//+ "\nPontos: " + Texto.pontosAuxiliar;
	}
}