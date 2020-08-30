using UnityEngine;

namespace ModularCollisionSample.Sample2
{
    [DisallowMultipleComponent, RequireComponent(typeof(Collider))]
    public class Coin : MonoBehaviour , ICollectable
    {
        public void Collect()
        {
            gameObject.SetActive(false);
            Debug.Log("Coin collected.");
        }
    }
}