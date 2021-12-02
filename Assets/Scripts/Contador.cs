/*
autor:Nícolas Romário
data: 04/11/2015
objetivo: conta cada tipo de lixo e diminui quando o objeto e destruido
*/

using UnityEngine;
using System.Collections;

public class Contador : MonoBehaviour {
	
	public static int contadorOrganico = 0;
	public static int contadorVidro = 0;
	public static int contadorPlastico = 0;
	public static int contadorMetal = 0;
	public static int contadorPapel = 0;

	void organico(){
		contadorOrganico++;
	}
	void vidro(){
		contadorVidro++;
	}
	void plastico(){
		contadorPlastico++;
	}
	void metal(){
		contadorMetal++;
	}
	void papel(){
		contadorPapel++;
	}
	
	
	
	void diminuiOrganico(){
		contadorOrganico--;
	}
	void diminuiVidro(){
		contadorVidro--;
	}
	void diminuiPlastico(){
		contadorPlastico--;
	}
	void diminuiMetal(){
		contadorMetal--;
	}
	void diminuiPapel(){
		contadorPapel--;
	}
}
