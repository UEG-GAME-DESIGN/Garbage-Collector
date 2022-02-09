/*
autor: Nícolas Romário.
data: 04/11/2015
objetivo: sortear o lixo em cada objeto e seleciana a tag correspondente
*/

using UnityEngine;
using System.Collections;

public class RandomObjects : MonoBehaviour {

    /*public Sprite img;
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
	public Sprite img40;*/

    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject obj17;
    public GameObject obj18;
    public GameObject obj19;
    public GameObject obj20;
    public GameObject obj21;
    public GameObject obj22;
    public GameObject obj23;
    public GameObject obj24;
    public GameObject obj25;
    public GameObject obj26;
    public GameObject obj27;
    public GameObject obj28;
    public GameObject obj29;
    public GameObject obj30;
    public GameObject obj31;
    public GameObject obj32;
    public GameObject obj33;
    public GameObject obj34;
    public GameObject obj35;
    public GameObject obj36;
    public GameObject obj37;
    public GameObject obj38;
    public GameObject obj39;
    public GameObject obj40;

    void Start(){

		Mesh[] objectArray = new Mesh[40];

		int r = Random.Range (0, 40);


		objectArray[0] = obj;
		objectArray[1] = obj2;
		objectArray[2] = obj3;
		objectArray[3] = obj4;
		objectArray[4] = obj5;
		objectArray[5] = obj6;
		objectArray[6] = obj7;
		objectArray[7] = obj8;
		objectArray[8] = obj9;
		objectArray[9] = obj10;
		objectArray[10] = obj11;
		objectArray[11] = obj12;
		objectArray[12] = obj13;
		objectArray[13] = obj14;
		objectArray[14] = obj15;
		objectArray[15] = obj16;
		objectArray[16] = obj17;
		objectArray[17] = obj18;
		objectArray[18] = obj19;
		objectArray[19] = obj20;
		objectArray[20] = obj21;
		objectArray[21] = obj22;
		objectArray[22] = obj23;
		objectArray[23] = obj24;
		objectArray[24] = obj25;
		objectArray[25] = obj26;
		objectArray[26] = obj27;
		objectArray[27] = obj28;
		objectArray[28] = obj29;
		objectArray[29] = obj30;
		objectArray[30] = obj31;
		objectArray[31] = obj32;
		objectArray[32] = obj33;
		objectArray[33] = obj34;
		objectArray[34] = obj35;
		objectArray[35] = obj36;
		objectArray[36] = obj37;
		objectArray[37] = obj38;
		objectArray[38] = obj39;
		objectArray[39] = obj40;

		this.gameObject.GetComponent<MeshFilter>().mesh = objectArray[r];

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
