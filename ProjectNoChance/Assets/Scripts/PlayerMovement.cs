using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public float upForce = 200f;
    private Rigidbody2D rb2d;
    public string sceneName;

    void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
