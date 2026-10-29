using UnityEngine;

public interface iInteractable
{
    Transform transform { get; }
    
    string DisplayName { get; }

    bool CanInteract();
    
    void Interact();
    
    void OnFocusGained();
    
    void OnFocusLost();
}


