using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaController : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        DataHolder.gainEnergy();
        Destroy(this.gameObject);
    }
}
