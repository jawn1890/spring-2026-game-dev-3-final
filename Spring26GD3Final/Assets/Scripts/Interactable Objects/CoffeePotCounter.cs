using Interactable_Objects.Interface;
using UnityEngine;

namespace Interactable_Objects
{
    public class CoffeePotCounter : MonoBehaviour, IInteractable
    {

        public void Interact()
        {
            Debug.Log("This will 'fill' the player's empty cup that they're holding!");
            //Actual logic for 'filling' cup will go here. Specific to the object, independent of any other scripts.
        }
    }
}