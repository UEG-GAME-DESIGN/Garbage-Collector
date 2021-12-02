/*
autor: Nícolas Romário.
data: 04/11/2015
objetivo: Monitorar a quantidade de pontos atuais para atribuir numa possivel superação de recorde.
*/

using UnityEngine;
using System.Collections;

public class Record : MonoBehaviour {

	public static int RecordAtual = 0;
	
	void Start () {
	
	}

	void Update () {
		if (RecordAtual <= AuxPontos.pontos) {
			RecordAtual = AuxPontos.pontos;
		}
	}
	
}
