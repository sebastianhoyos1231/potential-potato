using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecarmas : MonoBehaviour
{
    public GameObject gameObject, menu;
    
    public void activarSeleccion()
    {
        menu.SetActive(!menu.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }

}
