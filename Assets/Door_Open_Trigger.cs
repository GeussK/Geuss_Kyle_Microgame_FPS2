using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open_Trigger : MonoBehaviour
{
    [SerializeField] private Animator Door_OpenTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door_OpenTrigger.SetBool("Boss_Door_Open_Trigger", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door_OpenTrigger.SetBool("Boss_Door_Open_Trigger", false);
        }
    }
}
