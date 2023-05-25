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
   private float SpawnTime;


    // Update is called once per frame
    void Update()
    {
        float TimeBetweenSpawn = (System.MathF.Cbrt((float)Holder.Speed) / System.MathF.Sqrt((float)Holder.Speed)) * (float)Holder.BaseTimeBetweenCoins;
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
            Debug.Log(TimeBetweenSpawn);
        }
    }


    void Spawn()
    {
        float X = Random.Range(minX,maxY);
        float Y = Random.Range (minY,maxY);

        Instantiate (Coin, transform.position + new Vector3(X,Y,0), transform.rotation);

    }


}
