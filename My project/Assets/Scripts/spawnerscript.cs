using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
   public GameObject Coin;
   public float maxX;
   public float minX;
   public float maxY;
   public float minY;
   float TimeBetweenSpawn = 5f;
   private float SpawnTime;


    // Update is called once per frame
    void Update()
    {
        if(Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }


    void Spawn()
    {
        float X = Random.Range(minX,maxY);
        float Y = Random.Range (minY,maxY);

        Instantiate (Coin, transform.position + new Vector3(X,Y,0), transform.rotation);

    }


}
