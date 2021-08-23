using UnityEngine;

namespace CameraScripts
{
    //TODO: Change to new input system (optional)
    public class RotatingAroundObject : MonoBehaviour
    {
        private Vector2 _touchPosition;
        private Quaternion _rotationY;
        private float rotateSpeed = 0.1f;


        private void Update()
        {
            Transform pointTransform = transform;
            
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)) //For android
            {
                _rotationY = Quaternion.Euler(0f, -Input.GetTouch(0).deltaPosition.x * rotateSpeed, 0f);
                pointTransform.rotation = _rotationY * pointTransform.rotation;
            }

            if (Input.GetMouseButton(0)) //For pc
            {
                _rotationY = Quaternion.Euler(0f, ((Input.mousePosition.x - Screen.width / 2f) * rotateSpeed) / 250f, 0f);
                pointTransform.rotation = _rotationY * pointTransform.rotation;
            }
        }
    }
}