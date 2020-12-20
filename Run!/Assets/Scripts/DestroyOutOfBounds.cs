using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float bottomBound = 28;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when game object reaches less than bottom bound
        if (transform.position.x < -bottomBound)
        {
            // destroy game object 
            Destroy(gameObject);
        }
    }
}
