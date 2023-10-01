using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public GameObject shield;
    private bool shieldCount = true;
    // Update is called once per frame
    void Update()
    {
        if(shieldCount && DataHolder.energy > 0 && shield.activeSelf){
            DataHolder.energy--;
            shieldCount = false;
            StartCoroutine(countDownShield());
            Debug.Log("Energy is at: " + DataHolder.energy);
        }
        if(DataHolder.energy == 0){
            shield.SetActive(false);
        }
        if(DataHolder.energy >= 50){
            shield.SetActive(true);
        }
    }
    
    IEnumerator countDownShield(){
        yield return new WaitForSeconds(0.5f);
        shieldCount = true;        
    }
}
