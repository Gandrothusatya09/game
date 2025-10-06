using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public MeshRenderer m_Renderer;
    [SerializeField] private GameObject droppy;
    private Rigidbody rb;
    private void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();

        rb = droppy.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Dummy")
        {
            m_Renderer.material.color = Color.red;

        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Dummy")
        {
            m_Renderer.material.color = Color.blue;
        }
    }
    
}
