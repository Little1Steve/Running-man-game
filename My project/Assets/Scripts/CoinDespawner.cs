using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDespawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Holder.Coins += Holder.CoinsPerCoin;

    }
}
