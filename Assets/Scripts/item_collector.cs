using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_collector : MonoBehaviour
{

    private int cheeries = 0;

    [SerializeField] private Text CheeriesText;

    [SerializeField] private AudioSource collectionSoundeffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cheery"))
        {
            collectionSoundeffect.Play();
            Destroy(collision.gameObject);
            cheeries++;
            CheeriesText.text = "Cheeries: " + cheeries;
        }
    }

   
}
