using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("dooropen", 0, 0.0f);
                gameObject.SetActive(false);
                AudioManager.instance.PlayOneShot(FMODEvents.instance.doorOpen, this.transform.position);
            }

            else if (closeTrigger)
            {
                myDoor.Play("doorclose", 0, 0.0f);
                gameObject.SetActive(false);
                AudioManager.instance.PlayOneShot(FMODEvents.instance.doorClose, this.transform.position);
            }
        }
    }
}
