/*
autor:Nicolas Romario, Eduardo Henrique
data: 19/01/2015
objetivo: aparecer o record
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class TextoDoRecord2 : MonoBehaviour {
	

	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<TMP_Text>().text = /*"Recorde: " +*/ Record.RecordAtual.ToString();//+ "\nPontos: " + Texto.pontosAuxiliar;
    }
}