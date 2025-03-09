using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScreen : MonoBehaviour
{
    public void OnRestartButton(){
        SceneManager.LoadScene("_Scene_0");
    }
}
