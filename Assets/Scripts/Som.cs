/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: Tocar som quando trocar de cena.
*/

using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;

public class Som : MonoBehaviour {

	public AudioClip Musica;
	public GameObject IniciaAudio;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().clip = Musica;
		//audio.Play ();

		//DontDestroyOnLoad (IniciaAudio);

		SceneManager.LoadScene (0);
	}
}
