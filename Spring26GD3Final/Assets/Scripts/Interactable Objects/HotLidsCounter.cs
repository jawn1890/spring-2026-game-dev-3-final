using Interactable_Objects.Interface;
using UnityEngine;

namespace Interactable_Objects
{
    public class HotLidsCounter : MonoBehaviour, IInteractable
    {
        public GameObject prefabToSpawn;
        private GameObject _currentInstance;
        public Transform spawnPoint;

        public void Interact()
        {
            //Your actual logic for this particular counter goes here. It's specific to the item.
            ReplacePrefab();
        }

        void ReplacePrefab()
        {
            if (_currentInstance != null)
            {
                Destroy(_currentInstance);
            }
            _currentInstance = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
            _currentInstance.transform.SetParent(spawnPoint);

        }
    }
}