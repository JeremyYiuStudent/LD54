using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
	public GameObject title, story;
	private bool ready = false;
    public void StartGame()
	{
		title.SetActive(false);
		story.SetActive(true);
		ready = true;
		StartCoroutine(CountDown());
	}
	public void Exit()
	{
		Application.Quit ();
	}
	void Update(){
		if(ready && Input.anyKey){
			SceneManager.LoadScene ("MainGame");
		}
	}
    IEnumerator CountDown(){
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene ("MainGame");
    }

}
