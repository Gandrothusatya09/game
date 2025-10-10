using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{

    [SerializeField] private float movespeed;
    private void Update()
    {
        movement();
    }
    void movement()
    {
        float xvalue = Input.GetAxis("Horizontal") * movespeed* Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * movespeed* Time.deltaTime;
        transform.Translate(xvalue, 0, zvalue);


    }
}


