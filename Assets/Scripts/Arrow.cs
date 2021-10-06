using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject collidedObject;

    private void OnTriggerStay2D(Collider2D collision)
    {
        collidedObject = collision.gameObject;
    }
}
