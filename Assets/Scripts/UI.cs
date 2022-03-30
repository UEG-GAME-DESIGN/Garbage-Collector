/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer a pontuaçao e o cronometro na cena do jogo.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour {
	
	Text txt;
    TMP_Text text;

    void Start () {
		//txt = gameObject.GetComponent<Text>();
        text = gameObject.GetComponent<TMP_Text>();
    }

	void Update () {
		text.text =/* txt.text =*/ "Pontos: " + AuxPontos.pontos + "\nTempo: " + (int)Texto.cronometro;

	}
}