using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BETransition : MonoBehaviour
{
	private bool canMoveOn = false;
    public void Start()
	{
		StartCoroutine(CountDown());
	}
	void Update(){
		if(canMoveOn && Input.anyKey){
			SceneManager.LoadScene ("TitleScreen");
		}
	}
    IEnumerator CountDown(){
        yield return new WaitForSeconds(3);
		canMoveOn = true;
		yield return new WaitForSeconds(12);
        SceneManager.LoadScene ("TitleScreen");
    }

}
