using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        // set starting position to cuurent position
        startPos = transform.position;
        // repeat the background when it reaches half of its size
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // when current position is greater than the starting position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            // reset posiition
            transform.position = startPos;
        }
    }
}
