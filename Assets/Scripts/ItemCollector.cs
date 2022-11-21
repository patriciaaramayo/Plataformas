using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{

    int stars = 0;

    [SerializeField] Text starsText;

   [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            stars++;
            starsText.text = "Starts: " + stars;
            collectionSound.Play();
        }
    }

}