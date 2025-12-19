using UniRx;
using UnityEngine;
using VContainer.Unity;

namespace DefaultNamespace.InputController
{
    public class MouseInputController : ITickable
    {
        public readonly Subject<Transform> OnMouseButtonPressed = new();

        public MouseInputController()
        {
            
        }
        public void Tick()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector3.forward );                                                                                 
                //Debug.DrawRay(Camera.main.transform.position, mousePosition, Color.red, 2);
                if (hit.transform) 
                {
                    Debug.Log(hit.transform.name);
                    OnMouseButtonPressed.OnNext(hit.transform);
                }
            }
        }
    }
}