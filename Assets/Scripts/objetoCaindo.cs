/*
autor:Nícolas Romário
data: 04/11/2015
objetivo: quando clica no objeto ele é enviado a lixeira
*/

using UnityEngine;
using System.Collections;

public class objetoCaindo : MonoBehaviour {
	
	public GameObject lixo;
	
	private float distancia;
	private float velocidade = 20;
	public Transform target;
	
	void OnGui() {
		distancia = Vector3.Distance(transform.position, target.position); //Distancia entre a imagem do lixo e a lixeira
	}
	
	void Update(){
		if (lixo.transform.localPosition.y <= -3.5f) {
			//DestroyObject(lixo);//destroi a imagem quando chega na lixeira
			Destroy(lixo) ;
		}if(distancia > 0){//envia a imagem rumo a lixeira
			transform.position = Vector3.Lerp (transform.position, target.position,Time.deltaTime* velocidade/distancia*2);
		}
	}
}
