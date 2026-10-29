using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour, iInteractable
{
    [SerializeField] private string displayName ="Interact";
    [SerializeField] private bool isEnabled = true;
    [SerializeField] private UnityEvent onInteract;
    public string DisplayName => displayName;

    public bool CanInteract() => isEnabled;

    private Outline outline;

    private void Awake()
    {
        outline=gameObject.AddComponent<Outline>();
        if (outline == null) outline.OutlineMode = Outline.Mode.OutlineVisible;
        outline.OutlineColor = Color.red;
        outline.OutlineWidth = 5f;
        outline.enabled = false;
    }
   
    public void Interact()
    {
        onInteract?.Invoke();
    }

    public void OnFocusGained()
    {
        outline.enabled = true;
    }

    public void OnFocusLost()
    {
        outline.enabled = false;
    }
    
    
}
