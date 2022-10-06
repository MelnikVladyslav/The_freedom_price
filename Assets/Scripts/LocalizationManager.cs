using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    public void Ukr()
    {
        string language = "Ukr";
        PlayerPrefs.SetString("Language", language);
    }

    public void Eng()
    {
        string language = "Eng";
        PlayerPrefs.SetString("Language", language);
    }

}
