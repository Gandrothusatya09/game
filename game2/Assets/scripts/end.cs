using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    
    [SerializeField] ParticleSystem endparticles;
    private void Start()
    {
        endparticles.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            endparticles.Play();

        }
    }

}
