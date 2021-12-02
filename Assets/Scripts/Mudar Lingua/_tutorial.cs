/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer texto do tutorial
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class _tutorial : MonoBehaviour {

	private Text txt;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="\tNeste jogo você deve colocar os lixos nas lixeiras corretas antes que o tempo acabe.\n\n\tExistem cinco lixeiras: Plástico, Papel, Metal, Vidro e Orgânica.\n\n\tDescubra a cor que cada lixeira representa, encontre os lixos corretos e siga quebrando seu recorde.";

	}
}
