using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector timeline;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timeline.Play();
        }
    }
}
