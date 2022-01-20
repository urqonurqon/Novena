using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFunctions : MonoBehaviour
{
    [SerializeField]
    GameObject homeScreen, galleryScreen, textScreen;

    public void Home()
    {
        homeScreen.SetActive(true);
        galleryScreen.SetActive(false);
        textScreen.SetActive(false);
    }
    public void Gallery()
    {
        homeScreen.SetActive(false);
        galleryScreen.SetActive(true);
        textScreen.SetActive(false);
    }
    public void Text()
    {
        homeScreen.SetActive(false);
        galleryScreen.SetActive(false);
        textScreen.SetActive(true);
    }
}
