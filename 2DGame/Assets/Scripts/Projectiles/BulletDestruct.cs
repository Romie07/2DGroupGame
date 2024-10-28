using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestruct : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            if (collision.gameObject.tag != "PlayerBullet")
            {
                Destroy(gameObject);
            }
        }
    }
}
