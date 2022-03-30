using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance = null; 
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroy.instance == null)
        {
            DontDestroy.instance = this;
        }
        else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1 ) {
            DontDestroy.instance = null;
            Destroy(gameObject);
        }
    }
}
