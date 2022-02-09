using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public event EventHandler LanguageChanged;
    public static LanguageManager instance;
    public delegate void LanguageChangedEventHandler(object sender, LanguageChangedArgs e);
    public enum Languages { portuguese, english};
    public Languages language;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchLanguage() {
        if (language == Languages.english)
        {
            language = Languages.portuguese;
        }
        else {
            language = Languages.english;
        }
        OnLanguageChanged(new LanguageChangedArgs());
    }

    protected virtual void OnLanguageChanged(LanguageChangedArgs e)
    {
        LanguageChanged?.Invoke(this, e);
    }
}

public class LanguageChangedArgs : EventArgs
{
    public int Language { get; set; }
}
