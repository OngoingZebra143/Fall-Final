using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

      if(other.gameObject.CompareTag("Player"))
      {
          Debug.Log("player collected a coin.");
            Destroy(this.gameObject);
      }

      
    }
}
