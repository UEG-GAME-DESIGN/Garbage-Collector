/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer texto do botão voltar ao "menu"
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class _voltar : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<TMP_Text>().text = "Voltar ao menu";

    }
}
