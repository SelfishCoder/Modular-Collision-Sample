using UnityEngine;

namespace ModularCollisionSample.Sample1
{
    [DisallowMultipleComponent,RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour, IDamageable
    {
        private Collider cachedCollider;

        private void Start()
        {
            cachedCollider = GetComponent<Collider>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            ICollisionEnterResponse collisionEnterResponse = collision.gameObject.GetComponent<ICollisionEnterResponse>();
            collisionEnterResponse?.OnCollisionEnterResponse(cachedCollider);
        }

        private void OnCollisionStay(Collision collision)
        {
            ICollisionStayResponse collisionStayResponse = collision.gameObject.GetComponent<ICollisionStayResponse>();
            collisionStayResponse?.OnCollisionStayResponse(cachedCollider);
        }

        private void OnCollisionExit(Collision collision)
        {
            ICollisionExitResponse collisionExitResponse = collision.gameObject.GetComponent<ICollisionExitResponse>();
            collisionExitResponse?.OnCollisionExitResponse(cachedCollider);
        }

        public void TakeDamage(int damage)
        {
            Debug.Log($"Player took {damage.ToString()} damage");
        }
    }
}
