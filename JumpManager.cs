using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class JumpManager : MonoBehaviour {

	public void OnJump(int sceneIndex){
        SceneManager.LoadScene(sceneIndex);
        }
         
	public void OnQuit(){
	Application.Quit();
	}
}
