using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavalTrigger : MonoBehaviour
{
    public GameObject NavalParent;

    private void OnTriggerEnter(Collider other)
    {
        NavalParent.SetActive(true);
    }
}
