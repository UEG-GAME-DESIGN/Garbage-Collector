/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer texto de referencias
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class _referencias : MonoBehaviour {

	private Text txt;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Coordenador:\n    Ronaldo de Castro Del-Fiaco\nDesenvolvedores:\n    Eduardo Henrique J. Marques\n    Nícolas Romário M. Oliveira\nColaboradores:\n    Jonathan Henrique M. Souza\n    Yuri Eguti de Carvalho\n\n\nUniversidade Estadual de Goiás\nCampus Henrique Santillo\nSistemas de Informação\n\nProjeto Software Educativo e Educação Ambiental: Um Estudo Aplicado\nConvênio UEG/Ambev";
		
	}
}
