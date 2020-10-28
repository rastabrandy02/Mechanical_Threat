using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingPoint : MonoBehaviour
{
    private float playerPos;
    private float pos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos  = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        pos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if( playerPos > pos)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (playerPos < pos)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}
