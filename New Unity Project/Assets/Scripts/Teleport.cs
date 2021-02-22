using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Flag")
        {
            //teleport to 2nd stage
            transform.position = new Vector2(150, 0);
        }
        
        
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
