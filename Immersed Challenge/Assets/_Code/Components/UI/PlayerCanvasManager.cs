using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Canvas>().enabled = SceneManager.GetActiveScene().name != "Personal" && SceneManager.GetActiveScene().name != "Office";
    }
}
