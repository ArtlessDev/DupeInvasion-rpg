using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneChange : MonoBehaviour
{
    public string sceneString;

    // Start is called before the first frame update
    void Start()
    {
        //Scene scene = GetComponent<Scene>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(sceneString);
        Debug.Log("changing to " + sceneString);
    }
}
