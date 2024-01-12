using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeImageAppear : MonoBehaviour
{

    public bool imgOn;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        img.enabled = false;
        imgOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            if(imgOn == true)
            {
                img.enabled = false;
                imgOn = false;
            } else
            {
                img.enabled = true;
                imgOn = true;
            }
        }
    }

    /*void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (imgOn == true)
            {
                img.enabled = false;
                imgOn = false;
            }
            else
            {
                img.enabled = true;
                imgOn = true;
            }
        }
    }*/
}
