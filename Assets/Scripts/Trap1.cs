using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TrapBino.Piano;

namespace TrapBino.Trap1{
    public class Trap1 : MonoBehaviour
{

    [SerializeField]private Animator anim;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
            anim.SetBool("Sensor", true);
            Destroy(other, 3);
    }
}
}