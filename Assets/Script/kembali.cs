﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kembali : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyUp(KeyCode.Escape)){
           SceneManager.LoadScene("Menu");
       } 
    }
}
