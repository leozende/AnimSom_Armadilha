using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TrapBino.Trap1;

namespace TrapBino.Piano
{
    public class Piano : MonoBehaviour
{
    [SerializeField]private Rigidbody rbPiano;
    [SerializeField]private MeshRenderer mrPiano;

    public void Pin(){
        rbPiano.useGravity = true;
        mrPiano.enabled = true;
    }



}
}
