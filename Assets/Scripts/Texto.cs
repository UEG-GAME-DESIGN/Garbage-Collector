/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer a pontuaçao, o cronometro, e monitorar o click na cena do jogo.
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Texto : MonoBehaviour {

	public static int pontosAuxiliar = 0;
	public static float cronometro = 16;

	public AudioClip clique;
	
	private Ray inputRay;
	private RaycastHit inputHit;
	private bool inClick = false;
	
	public int auxiliar;

	void Start () {
		cronometro = 16 - (AuxPontos.pontos / 10);
	}

	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			inClick = true;

			GetComponent<AudioSource>().clip = clique;
			GetComponent<AudioSource>().Play();
		}
		
		inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if (Physics.Raycast (inputRay, out inputHit, 30)) {
			if (inClick == true) {

				inputHit.transform.SendMessage("OnGui", SendMessageOptions.RequireReceiver);//chama a funçao caindo da classe objetoCaindo
				
				
				if (inputHit.transform.tag == "organico" && RandomGarbage.r == 1) {
					AuxPontos.pontos = AuxPontos.pontos + 1;//aumenta os pontos
					Contador.contadorOrganico--;//diminui o numero do lixo que precisa ser selecionado
				}if (inputHit.transform.tag == "vidro" && RandomGarbage.r == 4) {
					AuxPontos.pontos = AuxPontos.pontos + 1;//aumenta os pontos
					Contador.contadorVidro--;//diminui o numero do lixo que precisa ser selecionado
				}if (inputHit.transform.tag == "plastico" && RandomGarbage.r == 2) {
					AuxPontos.pontos = AuxPontos.pontos + 1;//aumenta os pontos
					Contador.contadorPlastico--;//diminui o numero do lixo que precisa ser selecionado
				}if (inputHit.transform.tag == "metal" && RandomGarbage.r == 0) {
					AuxPontos.pontos = AuxPontos.pontos + 1;//aumenta os pontos
					Contador.contadorMetal--;//diminui o numero do lixo que precisa ser selecionado
				}if (inputHit.transform.tag == "papel" && RandomGarbage.r == 3) {
					AuxPontos.pontos = AuxPontos.pontos + 1;//aumenta os pontos
					Contador.contadorPapel--;//diminui o numero do lixo que precisa ser selecionado
				}

				if (inputHit.transform.tag == "organico" && RandomGarbage.r != 1) {
					pontosAuxiliar = AuxPontos.pontos;
					AuxPontos.pontos = 0;
					SceneManager.LoadScene (2);
				}if (inputHit.transform.tag == "vidro" && RandomGarbage.r != 4) {
					pontosAuxiliar = AuxPontos.pontos;
					AuxPontos.pontos = 0;
					SceneManager.LoadScene (2);
				}if (inputHit.transform.tag == "plastico" && RandomGarbage.r != 2) {
					pontosAuxiliar = AuxPontos.pontos;
					AuxPontos.pontos = 0;
					SceneManager.LoadScene (2);
				}if (inputHit.transform.tag == "metal" && RandomGarbage.r != 0) {
					pontosAuxiliar = AuxPontos.pontos;
					AuxPontos.pontos = 0;
					SceneManager.LoadScene (2);
				}if (inputHit.transform.tag == "papel" && RandomGarbage.r != 3) {
					pontosAuxiliar = AuxPontos.pontos;
					AuxPontos.pontos = 0;
					SceneManager.LoadScene (2);
				}
			}
		}
		
		if (cronometro >= 0) {
				cronometro = cronometro - Time.deltaTime;
			} else if (cronometro < 0) {
					pontosAuxiliar = AuxPontos.pontos;
					AuxPontos.pontos = 0;
					SceneManager.LoadScene(3);
					}
		
		if(RandomGarbage.r == 0 && Contador.contadorMetal == 0){

			Contador.contadorMetal = 0;
			Contador.contadorOrganico = 0;
			Contador.contadorPapel = 0;
			Contador.contadorPlastico = 0;
			Contador.contadorVidro = 0;
			
			SceneManager.LoadScene (1);

			RandomGarbage.r = Random.Range (0, 5);
		}if(RandomGarbage.r == 1 && Contador.contadorOrganico == 0){

			Contador.contadorMetal = 0;
			Contador.contadorOrganico = 0;
			Contador.contadorPapel = 0;
			Contador.contadorPlastico = 0;
			Contador.contadorVidro = 0;

			SceneManager.LoadScene (1);
;
			RandomGarbage.r = Random.Range (0, 5);
		}if(RandomGarbage.r == 2 && Contador.contadorPlastico == 0){

			Contador.contadorMetal = 0;
			Contador.contadorOrganico = 0;
			Contador.contadorPapel = 0;
			Contador.contadorPlastico = 0;
			Contador.contadorVidro = 0;

			SceneManager.LoadScene (1);

			RandomGarbage.r = Random.Range (0, 5);
		}if(RandomGarbage.r == 3 && Contador.contadorPapel == 0){

			Contador.contadorMetal = 0;
			Contador.contadorOrganico = 0;
			Contador.contadorPapel = 0;
			Contador.contadorPlastico = 0;
			Contador.contadorVidro = 0;

			SceneManager.LoadScene (1);

			RandomGarbage.r = Random.Range (0, 5);
		}if(RandomGarbage.r == 4 && Contador.contadorVidro == 0){
			
			Contador.contadorMetal = 0;
			Contador.contadorOrganico = 0;
			Contador.contadorPapel = 0;
			Contador.contadorPlastico = 0;
			Contador.contadorVidro = 0;

			SceneManager.LoadScene (1);

			RandomGarbage.r = Random.Range (0, 5);
		}
		
		inClick = false;
	}
}