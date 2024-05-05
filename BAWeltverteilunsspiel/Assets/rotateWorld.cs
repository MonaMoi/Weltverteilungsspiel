using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWorld : MonoBehaviour
{
    /*public float xAngle, yAngle, zAngle;

    public GameObject earth;

    void Awake()
    {
        earth = GameObject.CreatePrimitive(PrimitiveType.Cube);
        earth.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        earth.transform.Rotate(0.0f, 0.1f, 0.0f, Space.Self);
        earth.GetComponent<Renderer>().material.color = Color.red;
        earth.name = "Self";

    }

    void Update()
    {
        earth.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
    */
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.1f);
    }
}
