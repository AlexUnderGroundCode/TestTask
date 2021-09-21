using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticMoving : MonoBehaviour
{
    private float maxY = 0.3f;
    private float minY = -0.3f;
    public float _speed = 1f;
    

    private void Update()
    {
     
        
        transform.position += transform.up * _speed * Time.deltaTime;
    }


}
