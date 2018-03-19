using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class TriggerEvent : MonoBehaviour {

    public GameObject box;
    public GameObject door;
    public GameObject personCtrler;
    public Animation anim;

    void OnTriggerExit()
    {
        anim.CrossFade("Closed");
    }

    //上二楼
    public void UpStair2()
    {
        if (door.transform.position.y > -60)
        {
            personCtrler.transform.Translate(0f, -25f, 0f);
            box.transform.Translate(0f, -25f, 0f);
            door.transform.Translate(0f, -25f, 0f);
        }
        else
        {
            personCtrler.transform.Translate(0f, 25f, 0f);
            box.transform.Translate(0f, 25f, 0f);
            door.transform.Translate(0f, 25f, 0f);
        }
    }

    //上三楼
    public void UpStair3()
    {
        if (door.transform.position.y > -60)
        {
            personCtrler.transform.Translate(0f, 25.2f, 0f);
            box.transform.Translate(0f, 25f, 0f);
            door.transform.Translate(0f, 25f, 0f);
        }
        else
        {
            personCtrler.transform.Translate(0f, 50f, 0f);
            box.transform.Translate(0f, 50f, 0f);
            door.transform.Translate(0f, 50f, 0f);
        }
    }
}
