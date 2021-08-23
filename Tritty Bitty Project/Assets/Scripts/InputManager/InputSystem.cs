using System;
using RayFire;
using UnityEngine;

namespace InputManager
{
    public class InputSystem : MonoBehaviour
    {
        private TouchAndMouse _touchAndMouse;
        private Camera _mainCamera;

        public static event Action<SwipeData> OnTouchOrClick = delegate { };


        private void Awake()
        {
            _touchAndMouse = new TouchAndMouse();
            _touchAndMouse.PlayerInput.InputTouchedOrClicked.started += _ => TouchedScreen();

            _mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            _touchAndMouse.Enable();
        }

        private void OnDisable()
        {
            _touchAndMouse.Disable();
        }

        public struct SwipeData
        {
            public Vector2 Position;
            public RaycastHit Hit;
        }

        private void TouchedScreen()
        {
            DetectObject();
        }


        private void DetectObject()
        {
            Ray ray = _mainCamera.ScreenPointToRay(
                _touchAndMouse.PlayerInput.PostionTouchOrClicked.ReadValue<Vector2>());
            if (Physics.Raycast(ray, out RaycastHit hit) && hit.collider != null) //&&
                // hit.collider.GetComponent<RayfireShatter>() != null &&
                // hit.collider.CompareTag("Cube")) //BUG: first touch don`t got hit an object
            {
                SwipeData swipeData = new SwipeData
                {
                    Position = _touchAndMouse.PlayerInput.PostionTouchOrClicked.ReadValue<Vector2>(),
                    Hit = hit
                };
                OnTouchOrClick(swipeData);
            }
        }
    }
}