using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScript : MonoBehaviour
{
    public float moveSpeed = 7;
    public float outsideScreen = -55;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < outsideScreen)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
    }
}
