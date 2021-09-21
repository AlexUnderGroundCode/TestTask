using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsALL : MonoBehaviour
{

    public float forceJump = 50f;
    [SerializeField] ParticleSystem platformSplash = null;

    private void Start()
    {
        platformSplash.Stop();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
             Movement.instance.bounceRB.velocity = Vector2.up * forceJump;
        
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float randX = Random.Range(-1.7f, 1.7f);
            float randY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

            transform.position = new Vector3(randX, randY, 0);
        }
    }

}
