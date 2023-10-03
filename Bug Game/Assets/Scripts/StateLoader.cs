using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateLoader : MonoBehaviour
{
	public Animator transition;

	public float transitionTime = 1f;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("right"))
		{
			NextState();
		}
		if (Input.GetKey("left"))
		{
			PreviousState();
		}
	}


	public void NextState()
	{
		StartCoroutine(LoadState(SceneManager.GetActiveScene().buildIndex + 1));
	}

	public void PreviousState()
	{
		StartCoroutine(LoadState(SceneManager.GetActiveScene().buildIndex - 1));
	}

	//Creating coroutine??
	IEnumerator LoadState(int sceneIndex)
	{
		switch (sceneIndex)
		{
			case 0:
				transition.SetTrigger("Ready");
				break;
			case 1:
				transition.SetTrigger("EndGame");
				break;
		}

		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene(sceneIndex);
	}

}