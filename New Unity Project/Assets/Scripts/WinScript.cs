using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "WinFlag")
        {
           SceneManager.LoadScene("Win");
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}

    

