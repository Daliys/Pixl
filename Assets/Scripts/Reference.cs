using System;
using System.Collections;
using System.Collections.Generic;
using MenuUI;
using UI;
using UnityEngine;

public class Reference : MonoBehaviour
{
    public static Reference reference;

    [SerializeField] private MainMenuUI mainMenuUI;
    [SerializeField] private UIController uiController;
    [SerializeField] private Canvas mainMenuCanvas;
    [SerializeField] private Canvas gameCanvas;


    private void Awake()
    {
        if (reference != null)
        {
            Destroy(this);
        }
        else
        {
            reference = this;
        }
    }


    public MainMenuUI MainMenuUI => mainMenuUI;

    public UIController UIController => uiController;

    public Canvas MainMenuCanvas => mainMenuCanvas;

    public Canvas GameCanvas => gameCanvas;
}