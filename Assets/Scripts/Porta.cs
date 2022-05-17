using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{

    [SerializeField]private Animator anim;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag.Equals("Player"))
            anim.SetBool("Sensor", true);
        
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag.Equals("Player"))
            anim.SetBool("Sensor", false);
    }

}
