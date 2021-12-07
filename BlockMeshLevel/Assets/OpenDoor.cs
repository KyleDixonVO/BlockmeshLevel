using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject doorBottom;
    public GameObject doorTop;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorBottom.SetActive(false);
            doorTop.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
