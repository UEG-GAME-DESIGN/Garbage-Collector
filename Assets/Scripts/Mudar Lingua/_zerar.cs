﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class _zerar : MonoBehaviour {

	private Text txt;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Zerar";
		
	}
}
