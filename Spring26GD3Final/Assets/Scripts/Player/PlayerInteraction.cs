using Interactable_Objects.Interface;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInteraction : MonoBehaviour
    {
        public float interactDistance;
        public LayerMask interactableLayer;



        void Update()
        {
            if (Keyboard.current.pKey.wasPressedThisFrame)
            {
                Ray ray = new Ray(transform.position, transform.forward);
                if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, interactableLayer))
                {
                    if (hit.collider.TryGetComponent(out IInteractable interactable))
                    {
                        interactable.Interact();
                    }
                }
            }
        }
    }
}
