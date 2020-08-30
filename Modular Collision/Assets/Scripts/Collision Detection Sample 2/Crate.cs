using UnityEngine;

namespace ModularCollisionSample.Sample2
{
    [DisallowMultipleComponent, RequireComponent(typeof(Collider))]
    public class Crate : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interacted with crate.");
        }
    }
}