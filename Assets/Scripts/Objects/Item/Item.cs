using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tags;

public class Item : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagConst.PLAYER_TAG))
        {
            Destroy(gameObject);
            Debug.Log("Destroy Coins!");
        }
    }
}
