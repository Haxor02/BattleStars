using UnityEngine;

public class PickupBox : Interactable
{
    // this function is where we will design our interaction code.
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}
