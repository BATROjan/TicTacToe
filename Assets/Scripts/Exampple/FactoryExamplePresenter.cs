using System;
using JetBrains.Annotations;
using UnityEngine;
using VContainer.Unity;

namespace Exampple
{
    public class FactoryExamplePresenter : IDisposable//, IInitializable
    {
        private readonly FactoryExampleService _factoryExampleService;
        private readonly FactoryExampleModel _factoryExampleModel;

        public FactoryExamplePresenter(
           FactoryExampleService factoryExampleService
          // FactoryExampleModel factoryExampleModel
           )
        {
            _factoryExampleService = factoryExampleService;
          //  _factoryExampleModel = factoryExampleModel;
           Instantiate();
           Debug.Log("AAAAAAAAA");
        }
        public void Initialize()
        {
           //_factoryExampleModel.Button.onClick.AddListener(Instantiate);
        }

        private void Instantiate()
        {
            _factoryExampleService.Instantiate(0, 0);
        }

        public void Dispose()
        {
          //  _factoryExampleModel.Button.onClick.RemoveListener(Instantiate);
        }
    }
}