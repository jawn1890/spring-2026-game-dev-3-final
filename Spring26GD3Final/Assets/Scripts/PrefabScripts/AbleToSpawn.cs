using Interactable_Objects.Interface;
using UnityEngine;
using UnityEngine.Rendering;

public class AbleToSpawn : MonoBehaviour, ISpawnable
{
    public void Spawn(Transform parent)
    {
        Instantiate(gameObject, parent.position, Quaternion.identity, parent);
    }
}
