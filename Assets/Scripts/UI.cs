/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer a pontuaçao e o cronometro na cena do jogo.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	
	Text txt;

	void Start () {
		txt = gameObject.GetComponent<Text>();
	}

	void Update () {
		txt.text = "Pontos: " + AuxPontos.pontos + "\nCronômetro: " + (int)Texto.cronometro;
	}
}