/*
autor:Nícolas Romário
data: 04/11/2015
objetivo: sortear a lixeira e relacionar com a tag
*/

using UnityEngine;
using System.Collections;

public class RandomGarbage : MonoBehaviour {
	
	public Sprite lixeiraMetal; 
	public Sprite lixeiraOrganica;
	public Sprite lixeiraPlastico;
	public Sprite lixeiraPapel;
	public Sprite lixeiravidro;
	public static int r;

	void Start () {
		
		Sprite[] objectArray = new Sprite[5];
		
		objectArray[0] = lixeiraMetal;
		objectArray[1] = lixeiraOrganica;
		objectArray[2] = lixeiraPlastico;
		objectArray[3] = lixeiraPapel;
		objectArray[4] = lixeiravidro;

		r = Random.Range (0, 5);
		this.gameObject.GetComponent<SpriteRenderer>().sprite = objectArray[r];
		
		if (r == 0) {
			gameObject.tag = "metal";
		}if (r == 1) {
			gameObject.tag = "organico";
		}if (r == 2) {
			gameObject.tag = "plastico";
		}if (r == 3) {
			gameObject.tag = "papel";
		}if (r == 4) {
			gameObject.tag = "vidro";
		}
		
	}
}

