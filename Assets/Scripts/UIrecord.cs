﻿/*
autor: Nícolas Romário
data: 04/11/2015
objetivo: aparecer tela de recorde
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIrecord : MonoBehaviour
{

    Text txt;

    // Use this for initialization
    void Start()
    {
        txt = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Recorde: " + Record.RecordAtual + "\nPontos: " + Texto.pontosAuxiliar;
    }
}