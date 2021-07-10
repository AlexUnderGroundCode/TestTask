using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public static Movement instance;
    public Transform player;
    public float speed = 0f;
    private bool alive = true;
    public Rigidbody2D bounceRB;
    
 
    void Start()
    {
        if (instance == null) instance = this;
    }

    private void OnMouseDrag()
    {
        if (alive)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;             // ограничение перемещения игрока
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position,
                new Vector2(mousePos.x, player.position.y),             //реализация плавного перемещения игрока 
                speed * Time.deltaTime);
        }

        if (player.position.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (player.position.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
       

      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(0);
        }
    }


    void Update()
    {
        OnMouseDrag();
    }
}
