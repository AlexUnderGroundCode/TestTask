using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform positionBall;

    void Update()
    {
        if(positionBall.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, positionBall.position.y, transform.position.z);
        }
    }
}
