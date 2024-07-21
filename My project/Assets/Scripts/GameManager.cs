using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class GameManager : MonoBehaviour // Исправлено название класса
{
    [SerializeField]
    private GameObject carPrefab;

    [SerializeField]
    private Camera arCamera;

    private GameObject carController;

    private Rect resetButton; // Изменено на поле для Rect

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        // Присваиваем значение resetButton в Awake
        GameObject resetButtonObject = GameObject.FindGameObjectWithTag("ResetButton");
        if (resetButtonObject != null)
        {
            RectTransform rectTransform = resetButtonObject.GetComponent<RectTransform>();
            resetButton = new Rect(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y, rectTransform.rect.width, rectTransform.rect.height);
        }
        else
        {
            Debug.LogError("ResetButton с тегом не найден!");
        }
    }

    private void Update()
    {
        var activeTouches = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches;
        if (activeTouches.Count > 0)
        {
            var touch = activeTouches[0];

            bool isOverUI = touch.screenPosition.IsPointOverUIObject();

            if (isOverUI)
            {
                if (resetButton.Contains(touch.screenPosition))
                {
                    OnResetButtonPressed();
                }
                Debug.Log("UI is touched");
                return;
            }

            if (touch.phase == UnityEngine.InputSystem.TouchPhase.Began)
            {
                var ray = arCamera.ScreenPointToRay(touch.screenPosition);
                var hasHit = Physics.Raycast(ray, out var hit, float.PositiveInfinity);

                if (hasHit && carController == null)
                {
                    carController = Instantiate(carPrefab, hit.point, Quaternion.identity);
                    InputController.Instance.Bind(carController.GetComponent<CarController>());
                }
            }
        }
    }

    public void OnResetButtonPressed()
    {
        Debug.Log("Кнопка Pause нажата!");
       
    }
}
