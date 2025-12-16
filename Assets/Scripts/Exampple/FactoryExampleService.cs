using System;
using UI;
using UnityEngine;

namespace Exampple
{
    public class FactoryExampleService
    {
        private readonly Func<Vector3, BaseUIWindowView> _factory;

        FactoryExampleService(Func<Vector3, BaseUIWindowView> factory)
        {
            _factory = factory;
        }

        public void Instantiate(float x, float z)
        {
            _factory.Invoke(Vector3.zero);
        }
    }
}