using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // message displayed to player when looking at an interactable
    public string promptMessage;

    // called from player
    public void BaseInteract()
    {
        Interact();
    }
    
    protected virtual void Interact()
    {
        // template function to be overriden by subclass
    }
}
