using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public MeshRenderer m_Renderer;
    
    private Rigidbody rb;

    
    private void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();

       
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Renderer.material.color = Color.red;
           
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Renderer.material.color = Color.blue;
        }
    }
    
}
