﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("02GamePlay");
    }
    public void Credits()
    {
        SceneManager.LoadScene("03Credits");
    }
}
