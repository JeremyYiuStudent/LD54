using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameObject safetySphere;
    private bool canDamage = true;
    private bool canHeal = true;
    void Update(){
        float dist = Vector3.Distance(this.transform.position, safetySphere.transform.position);
        if(dist>5 || !safetySphere.activeSelf){
            if(canDamage){
                DataHolder.reduceHealth(safetySphere.activeSelf ? 1 : 2);
                canDamage = false;
                StartCoroutine(countDownDamage());
            }
        }else{
            if(canHeal && safetySphere.activeSelf){
                DataHolder.increaseHealth();
                canHeal = false;
                StartCoroutine(countDownHeal());
            }
        }
    }
    IEnumerator countDownDamage(){
        yield return new WaitForSeconds(2);
        canDamage = true;        
    }
    IEnumerator countDownHeal(){
        yield return new WaitForSeconds(1);
        canHeal = true;        
    }
}
