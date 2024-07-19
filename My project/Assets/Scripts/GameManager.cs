using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class Gameanager : MonoBehaviour
{
   [SerializeField]
   private GameObject carPrefab;

   [SerializeField]
   private Camera arCamera;

   private GameObject carController;

   private void Awake(){
    EnhancedTouchSupport.Enable();
   }

   private void Update(){
    var activeTouches = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches;
    if(activeTouches.Count > 0){
        var touch = activeTouches[0];

        bool isOverUI = touch.screenPosition.IsPointOverUIObject();

        if(isOverUI) return;

        if(touch.phase == UnityEngine.InputSystem.TouchPhase.Began){
            var ray = arCamera.ScreenPointToRay(touch.screenPosition);
            var hasHit = Physics.Raycast(ray, out var hit, float.PositiveInfinity);

            if(hasHit && carController == null){
                carController = Instantiate(carPrefab, hit.point, Quaternion.identity);
                InputController.Instance.Bind(carController.GetComponent<CarController>());

            }
        }
    }
   }
}
