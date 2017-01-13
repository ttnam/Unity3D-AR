﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.Globals;

public class DialogPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void go()
    {
        SceneManager.LoadScene(Global.DETAIL_SCENE);
    }
    public void earth()
    {
        SceneManager.LoadScene(Global.MAIN_SCENE);

    }
    public void contact()
    {
        Application.OpenURL("https://github.com/ttnam/Unity3D-AR");
    }

    public void exit()
    {
        Application.Quit();
    }
}
