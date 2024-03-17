using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Trig : MonoBehaviour
{
    [SerializeField] private Animator Key_Trig_Open;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Key_Trig_Open.SetBool("Touched_Key_Trigger", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Key_Trig_Open.SetBool("Touched_Key_Trigger", false);
        }
    }
}
