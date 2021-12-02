/*
autor:Nicolas Romario, Eduardo Henrique
data: 19/01/2015
objetivo: aparecer o record
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextoDoRecord2 : MonoBehaviour {
	
	Text txt;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Record: " + Record.RecordAtual + "\nCurrent: " + Texto2.pontosAuxiliar;
	}
}