using UnityEngine;

namespace ModularCollisionSample.Sample1
{
    public interface ICollisionExitResponse
    {
        void OnCollisionExitResponse(Collider other);
    }
}