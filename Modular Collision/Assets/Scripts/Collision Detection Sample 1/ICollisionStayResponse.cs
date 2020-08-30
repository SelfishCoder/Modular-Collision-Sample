using UnityEngine;

namespace ModularCollisionSample.Sample1
{
    public interface ICollisionStayResponse
    {
        void OnCollisionStayResponse(Collider other);
    }
}