using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 4);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -4);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-4, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(4, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.name == "DoomWall")
        {
            Debug.Log("haha cat paw");
            Destroy(gameObject);
            SceneManager.LoadScene("BadEndScreen");
        }
        else if (collide.gameObject.name == "ExitPipe")
        {
            Debug.Log("Player has escaped level");
            SceneManager.LoadScene("EndScreen");
        }
    }
}
