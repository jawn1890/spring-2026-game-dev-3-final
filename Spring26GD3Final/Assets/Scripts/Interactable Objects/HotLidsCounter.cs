using Interactable_Objects.Interface;
using UnityEngine;

namespace Interactable_Objects
{
    public class HotLidsCounter : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("This will 'cap' the player's full cup that they're holding and make it a 'complete' drink!");
            //Actual logic for 'capping' cup will go here. Specific to the object, independent of any other scripts.
        }
    }
}