using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    [SerializeField] Animator animatorDoor1;
    [SerializeField] Animator animatorDoor2;
    private bool isOpen;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && !isOpen)
        {
            if(!animatorDoor1.enabled) animatorDoor1.enabled = true;
            animatorDoor1.SetTrigger("Toggle");
            if(!animatorDoor2.enabled) animatorDoor2.enabled = true;
            animatorDoor2.SetTrigger("Toggle");
            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player") && isOpen)
        {
            animatorDoor1.SetTrigger("Toggle");
            animatorDoor2.SetTrigger("Toggle");
            isOpen = false;
        }
    }
}
