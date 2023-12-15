using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Add or remove an InteractionEvent component to this gameObject;
    public bool useEvents;
    // message displayed to player when looking at an interactable
    public string promptMessage;

    // called from player
    public void BaseInteract()
    {
        if(useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    
    protected virtual void Interact()
    {
        // template function to be overriden by subclass
    }
}
