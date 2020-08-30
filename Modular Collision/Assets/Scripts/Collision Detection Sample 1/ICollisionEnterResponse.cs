using UnityEngine;

namespace ModularCollisionSample.Sample1
{
    public interface ICollisionEnterResponse
    {
        void OnCollisionEnterResponse(Collider other);
    }
}
