using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float height = 24;
    public Rigidbody2D physicsBody;

    public GameLogic logic;
    private bool notCollided = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && notCollided)
        {
            physicsBody.velocity = Vector2.up * height;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        notCollided = false;
        logic.GameOver();
    }
    private void OnBecameInvisible()
    {
        notCollided = false;
        logic.GameOver();
    }
}
