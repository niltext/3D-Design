using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour {

    public GameObject personCtrler;
    public GameObject director;
    public GameObject imag;
    public float speed = 40f;

    private float endX = 70f;

    void Update () {
	
        if(transform.position.x > endX)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            personCtrler.SetActive(true);
            director.SetActive(true);
            imag.SetActive(true);
            gameObject.SetActive(false);
        }
	}
}

