using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{

   [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            HUDGame.stars++;
            collectionSound.Play();
        }
    }

}