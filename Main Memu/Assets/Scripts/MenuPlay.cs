using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour {

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
}
