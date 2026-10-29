using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] private float radius = 12f;
    [SerializeField] private LayerMask interactableLayers;

    private Collider[] buffer = new Collider[32];
    private iInteractable focused;

    private void Update()
    {
        iInteractable nearest = FindNearestInteractable();
        UpdateFocus(nearest);
        if (focused != null && Input.GetKeyDown(KeyCode.E) && focused.CanInteract())
        {
            if(focused.CanInteract()) focused.Interact();
        }
        
        
    }

    private iInteractable FindNearestInteractable()
    {
        
        int count = Physics.OverlapSphereNonAlloc(transform.position, radius, buffer, interactableLayers, QueryTriggerInteraction.Collide);
        iInteractable nearest = null;
        float bestDistSq=float.MaxValue;
        for (int i = 0; i < count; i++)
        {
            Collider col = buffer[i];
            if (col == null) continue;
            iInteractable interactable = col.GetComponentInParent<iInteractable>();
            if (interactable == null) continue;
            if (!interactable.CanInteract()) continue;
            float distSq=(col.transform.position-transform.position).sqrMagnitude;
            if (distSq < bestDistSq)
            {
                bestDistSq=distSq;
                nearest = interactable;
            }
        }
        return nearest;
    }
    private void UpdateFocus(iInteractable nearest)
    {
        if (ReferenceEquals(focused, nearest)) return;
        focused?.OnFocusLost();
        focused = nearest;
        focused?.OnFocusGained();
    }
}
