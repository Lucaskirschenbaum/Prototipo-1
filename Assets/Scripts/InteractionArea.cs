using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Collectible"))
        {
            Destroy(col.gameObject);
            GameManager.instance.AddScore();
        }
    }
}
