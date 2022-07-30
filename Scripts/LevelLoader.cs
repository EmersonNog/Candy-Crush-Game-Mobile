using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	public Animator transitionAnim;

	public void Transition(string sceneName)
	{
		StartCoroutine(LoadScene(sceneName));
	}

	IEnumerator LoadScene(string sceneName)
	{
		transitionAnim.SetTrigger("Comeco");

		yield return new WaitForSeconds(0.1f);

		SceneManager.LoadScene(sceneName);
	}
}
