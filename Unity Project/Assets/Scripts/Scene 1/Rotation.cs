using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    GameObject toggle;
    float rotationspeed = 10.0f;
    GameObject cube1;
    private void Start()
    {
        toggle = GameObject.Find("XaxisLock");
        toggle.GetComponent<Toggle>().isOn = false;
    }
    void Update()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationspeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationspeed;

        transform.Rotate(Vector3.down, XaxisRotation);
        transform.Rotate(Vector3.right, YaxisRotation);
    }
    public void ToggleXaxis( bool xaxis)
    {

        if (toggle.GetComponent<Toggle>().isOn == true)
        {
            cube1 = GameObject.Find("Cube1");
            cube1.transform.rotation = Quaternion.identity;
            GetComponent<Rotation>().enabled = false;
        }
        else
        {
            GetComponent<Rotation>().enabled = true;
        }

        

    }
}
