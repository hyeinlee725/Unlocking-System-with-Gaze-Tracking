﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class button_reenroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Changedd()
    {
        //Debug.Log("click!");
        File.Delete("C:\\Users\\minji\\Desktop\\unity_practice\\lenon test\\Assets\\Resources\\realTime.csv");
        File.Delete("C:\\Users\\minji\\Desktop\\unity_practice\\lenon test\\Assets\\Resources\\realTime.csv.meta");
        File.Delete("C:\\Users\\minji\\Desktop\\unity_practice\\lenon test\\Assets\\Resources\\password.txt");
        File.Delete("C:\\Users\\minji\\Desktop\\unity_practice\\lenon test\\Assets\\Resources\\password.txt.meta");
        SceneManager.LoadScene("Scene2-1");
    }
}
