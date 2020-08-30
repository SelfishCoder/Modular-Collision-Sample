using UnityEngine;

namespace ModularCollisionSample.Sample2
{
    [DisallowMultipleComponent, RequireComponent(typeof(Rigidbody), typeof(Collider))]
    public class Player : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            other.gameObject.GetComponent<ICollectable>()?.Collect();
            other.gameObject.GetComponent<IInteractable>()?.Interact();
        }
    }
}