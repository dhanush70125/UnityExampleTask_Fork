using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xaxisLock : MonoBehaviour
{
    float rotationspeed = 10.0f;
    // Start is called before the first frame update
    void Update()
    {

        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationspeed;


        transform.Rotate(Vector3.right, YaxisRotation);
    }
}
