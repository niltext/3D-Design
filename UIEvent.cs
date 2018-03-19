using UnityEngine;
using System.Collections;

public class UIEvent : MonoBehaviour {

    public GameObject startimg;
    public GameObject cursor;

    public GameObject FreeViewCamera;
    public GameObject FPSCtrler;
    public GameObject BackImg;
	
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public void OnStart()
    {
        
        startimg.SetActive(false);
        
        cursor.SetActive(true);
    }

    public void FreeView()
    {
        startimg.SetActive(false);
        FPSCtrler.SetActive(false);
        FreeViewCamera.SetActive(true);
        BackImg.SetActive(true);
    }

    public void OnBack()
    {
        startimg.SetActive(true);
        FPSCtrler.SetActive(true);
        FreeViewCamera.SetActive(false);
        BackImg.SetActive(false);
    }
}
