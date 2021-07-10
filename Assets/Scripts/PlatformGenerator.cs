using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public int numsOfPlatforms = 200;
    public float levelWidth = 2.5f;
    public float minY = .2f;
    public float maxY = 1.5f;

    void Start()
    {
        
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < numsOfPlatforms; i++)
        {
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            spawnPos.y += Random.Range(minY, maxY);
            Instantiate(platform, spawnPos, Quaternion.identity);
        }

    }

}
