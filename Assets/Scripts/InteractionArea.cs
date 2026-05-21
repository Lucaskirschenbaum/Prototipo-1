using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public int score = 0;
    public UIManager uiManagerScript;

    void Awake()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Collectible")){
            Destroy (col.gameObject);
            score ++;
            uiManagerScript.UpdateScore(score);
        }
    
    }
}
