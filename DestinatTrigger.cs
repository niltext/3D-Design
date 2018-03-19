using UnityEngine;
using System.Collections;

public class DestinatTrigger : MonoBehaviour {

    public Animation anim;

    void OnTriggerEnter()
    {
        anim.CrossFade("Open");

    }

    void OnTriggerExit()
    {
        anim.CrossFade("Closed");
    }
}
