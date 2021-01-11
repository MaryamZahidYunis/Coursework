using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bricks : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Ball":
                // Ball destroys Bricks when hit
                Destroy(gameObject);
                break;
        }
    }
}
