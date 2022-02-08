using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EditorSceneManager.LoadScene("TestScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
