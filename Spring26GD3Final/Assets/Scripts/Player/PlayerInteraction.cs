using Interactable_Objects.Interface;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInteraction : MonoBehaviour
    {
        public float interactDistance;
        public LayerMask interactableLayer;
        private GameObject _prefabWithInterface;


        void Update()
        {
            if (Keyboard.current.pKey.wasPressedThisFrame)
            {
                PerformInteraction();
                Spawn(this.transform);


            }
        }

        void PerformInteraction()
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

        public void Spawn(Transform parent)
        {
            ISpawnable spawnable = _prefabWithInterface.GetComponent<ISpawnable>();

            if (spawnable != null)
            {
                spawnable.Spawn(this.transform);
            }
        }
    }
}