using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class _reiniciar : MonoBehaviour {

	private Text txt;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<TMP_Text>().text="Reiniciar";
		
	}
}
