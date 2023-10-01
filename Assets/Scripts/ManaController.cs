using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaController : MonoBehaviour
{
    void OnCollisionEnter(Collision c){
        DataHolder.gainEnergy();
        Destroy(this.gameObject);
    }
}
