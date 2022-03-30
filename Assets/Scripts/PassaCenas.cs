using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PassaCenas : MonoBehaviour {

	private Ray inputRay;
	private RaycastHit inputHit;
	public static bool trocar = true;



	public void play(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (1);
		SceneManager.LoadScene (1);
	}
	public void gameOverLixo(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (2);
		SceneManager.LoadScene (3);

	}
	public void gameOverLixoTime(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (3);
		SceneManager.LoadScene (3);

	}
	public void credito(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (5);
		SceneManager.LoadScene (5);

	}
	public void ajuda(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (6);		
		SceneManager.LoadScene (6);

	}
	public void menuIniciar(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (0);
		SceneManager.LoadScene (0);

	}
	public void sairdoJogo(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
        Application.Quit();
    }
	public void IrParaRecord(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (4);
		SceneManager.LoadScene (4);

		
	}

	public void Mudar(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (11);
		SceneManager.LoadScene (11);

	}

	public void play2(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (9);
		SceneManager.LoadScene (9);

	}

	public void gameOverLixo2(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (10);
		SceneManager.LoadScene (10);

	}

	public void gameOverLixoTime2(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (11);
		SceneManager.LoadScene (11);

	}

	public void credito2(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (8);
		SceneManager.LoadScene (8);

	}

	public void ajuda2(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (7);
		SceneManager.LoadScene (7);

	}

	public void IrParaRecord2(){
		Contador.contadorMetal = 0;
		Contador.contadorOrganico = 0;
		Contador.contadorPapel = 0;
		Contador.contadorPlastico = 0;
		Contador.contadorVidro = 0;
		//Application.LoadLevel (12);
		SceneManager.LoadScene (12);

	}

	
	
}
