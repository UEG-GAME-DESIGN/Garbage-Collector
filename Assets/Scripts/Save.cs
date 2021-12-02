/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: Salvar o record no banco de dados e carregar do BD quando o jogo é iniciado.
*/

using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour{

	public GameObject dex;

	void OnEnable (){

		DontDestroyOnLoad (dex);
		
		if (PlayerPrefs.HasKey ("dadosSalvosRecord")) {
			Record.RecordAtual = PlayerPrefs.GetInt("dadosSalvosRecord");
		}
		
	}
	
	void OnDisable (){
		PlayerPrefs.SetInt("dadosSalvosRecord", Record.RecordAtual);

	}
}
