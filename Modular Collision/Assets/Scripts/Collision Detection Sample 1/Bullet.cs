using UnityEngine;

namespace ModularCollisionSample.Sample1
{
    [DisallowMultipleComponent,RequireComponent(typeof(Collider))]
    public class Bullet : MonoBehaviour, ICollisionEnterResponse
    {
        [SerializeField] private int damage = 10;
        
        public void OnCollisionEnterResponse(Collider other)
        {
            IDamageable damageable = other.gameObject.GetComponent<IDamageable>();
            damageable?.TakeDamage(damage);
        }
    }
}