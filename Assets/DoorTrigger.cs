using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator Door_Close_Trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door_Close_Trigger.SetBool("Boss_Door_Close_Trigger", true);
        }
     }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door_Close_Trigger.SetBool("Boss_Door_Close_Trigger", false);
        }
    }
}
