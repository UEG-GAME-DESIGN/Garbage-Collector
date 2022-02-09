using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MultilangText : MonoBehaviour
{
    public string Texto_Pt;
    public string Texto_En;
    public enum TextType { TextMeshPRO,UnityText };
    public TextType TipoDeTexto;
    public LanguageManager.Languages linguagemPadrao; //a lingua em que o texto é escrito por padrão, o texto do componente sera escrito na string 
                                                      //correspondente a essa linguagem caso a string esteja vazia
    // Start is called before the first frame update
    void Start()
    {
        
        if (LanguageManager.instance.language == LanguageManager.Languages.english && (Texto_En == null|| Texto_En ==""))
        {
            if (TipoDeTexto == TextType.TextMeshPRO)
            {
                Texto_En = gameObject.GetComponent<TMP_Text>().text;
            }
            else
            {
                Texto_En = gameObject.GetComponent<TMP_Text>().text;
            }
        }
        else if (Texto_Pt == null || Texto_Pt == "")
        {
            if (TipoDeTexto == TextType.TextMeshPRO)
            {
                Texto_Pt = gameObject.GetComponent<TMP_Text>().text;
            }
            else
            {
                Texto_Pt = gameObject.GetComponent<TMP_Text>().text;
            }
        }


        string texto;
        if (LanguageManager.instance.language == LanguageManager.Languages.english)
        {
            texto = Texto_En;
        }
        else
        {
            texto = Texto_Pt;
        }


        if (TipoDeTexto == TextType.TextMeshPRO)
        {
            gameObject.GetComponent<TMP_Text>().text = texto;
        }
        else
        {
            gameObject.GetComponent<Text>().text = texto;
        }

        LanguageManager.instance.LanguageChanged += C_LanguageChanged;

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void C_LanguageChanged(object sender, EventArgs e)
    {
        string texto;
        if (LanguageManager.instance.language == LanguageManager.Languages.english) {
            texto = Texto_En;
        }
        else
        {
            texto = Texto_Pt;
        }


        if (TipoDeTexto == TextType.TextMeshPRO)
        {
            gameObject.GetComponent<TMP_Text>().text = texto;
        }
        else {
            gameObject.GetComponent<Text>().text = texto;
        }

    }
}
