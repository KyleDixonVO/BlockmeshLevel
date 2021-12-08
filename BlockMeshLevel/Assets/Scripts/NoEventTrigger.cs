using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEventTrigger : MonoBehaviour
{
    public GameObject NavalParent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NavalParent.SetActive(false);
        }
    }
}
