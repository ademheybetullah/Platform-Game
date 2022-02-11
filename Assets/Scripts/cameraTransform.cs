using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTransform : MonoBehaviour
{
    public GameObject followTransform;


    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.transform.position.x, this.transform.position.y, this.transform.position.z);


    }
}
