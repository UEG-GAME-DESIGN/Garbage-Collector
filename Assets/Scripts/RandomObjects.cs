/*
autor: Nícolas Romário.
data: 04/11/2015
objetivo: sortear o lixo em cada objeto e seleciana a tag correspondente
*/

using UnityEngine;
using System.Collections;

public class RandomObjects : MonoBehaviour {

	public Sprite img;
	public Sprite img2;
	public Sprite img3;
	public Sprite img4;
	public Sprite img5;
	public Sprite img6;
	public Sprite img7;
	public Sprite img8;
	public Sprite img9;
	public Sprite img10;
	public Sprite img11;
	public Sprite img12;
	public Sprite img13;
	public Sprite img14;
	public Sprite img15;
	public Sprite img16;
	public Sprite img17;
	public Sprite img18;
	public Sprite img19;
	public Sprite img20;
	public Sprite img21;
	public Sprite img22;
	public Sprite img23;
	public Sprite img24;
	public Sprite img25;
	public Sprite img26;
	public Sprite img27;
	public Sprite img28;
	public Sprite img29;
	public Sprite img30;
	public Sprite img31;
	public Sprite img32;
	public Sprite img33;
	public Sprite img34;
	public Sprite img35;
	public Sprite img36;
	public Sprite img37;
	public Sprite img38;
	public Sprite img39;
	public Sprite img40;

	void Start(){

		Sprite[] objectArray = new Sprite[40];

		int r = Random.Range (0, 40);


		objectArray[0] = img;
		objectArray[1] = img2;
		objectArray[2] = img3;
		objectArray[3] = img4;
		objectArray[4] = img5;
		objectArray[5] = img6;
		objectArray[6] = img7;
		objectArray[7] = img8;
		objectArray[8] = img9;
		objectArray[9] = img10;
		objectArray[10] = img11;
		objectArray[11] = img12;
		objectArray[12] = img13;
		objectArray[13] = img14;
		objectArray[14] = img15;
		objectArray[15] = img16;
		objectArray[16] = img17;
		objectArray[17] = img18;
		objectArray[18] = img19;
		objectArray[19] = img20;
		objectArray[20] = img21;
		objectArray[21] = img22;
		objectArray[22] = img23;
		objectArray[23] = img24;
		objectArray[24] = img25;
		objectArray[25] = img26;
		objectArray[26] = img27;
		objectArray[27] = img28;
		objectArray[28] = img29;
		objectArray[29] = img30;
		objectArray[30] = img31;
		objectArray[31] = img32;
		objectArray[32] = img33;
		objectArray[33] = img34;
		objectArray[34] = img35;
		objectArray[35] = img36;
		objectArray[36] = img37;
		objectArray[37] = img38;
		objectArray[38] = img39;
		objectArray[39] = img40;

		this.gameObject.GetComponent<SpriteRenderer>().sprite = objectArray[r];

		if(r <= 7){
			gameObject.tag = "metal";
			SendMessage("metal",  SendMessageOptions.RequireReceiver);
		}if(r >= 8 && r <= 15){
			gameObject.tag = "papel";
			SendMessage("papel",  SendMessageOptions.RequireReceiver);
		}if (r >= 16 && r <= 23) {
			gameObject.tag = "organico";
			SendMessage("organico",  SendMessageOptions.RequireReceiver);
		}if(r >= 24 && r <= 31){
			gameObject.tag = "plastico";
			SendMessage("plastico",  SendMessageOptions.RequireReceiver);
		}if(r >= 32 && r <= 39){
			gameObject.tag = "vidro";
			SendMessage("vidro",  SendMessageOptions.RequireReceiver);
		}
	}
}
