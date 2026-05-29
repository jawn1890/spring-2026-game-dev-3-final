using Interactable_Objects.Interface;
using UnityEngine;
using Debug = UnityEngine.Debug;


namespace Interactable_Objects
{
    public class HotCupsCounter : MonoBehaviour, IInteractable
    {
        
        public void Interact()
        {
            Debug.Log("This will 'give' the player an empty cup!");
            //The rest of your actual logic for this particular counter goes here. It's specific to the item.
        }
    }
}