using UnityEngine;
using System.Collections;

public class ZerarRecord : MonoBehaviour {

	// Use this for initialization
	public void Zerando () {
		Record.RecordAtual = 0;
		//PlayerPrefs.SetInt("dadosSalvosRecord", Record.RecordAtual);
	}
}
