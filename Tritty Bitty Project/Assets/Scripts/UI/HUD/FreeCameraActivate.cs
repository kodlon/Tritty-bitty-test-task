using CameraScripts;
using UnityEngine;

namespace UI.HUD
{
    public class FreeCameraActivate : MonoBehaviour
    {
        [SerializeField] private GameObject rotatingAround;

        public void OnFreeCameraPressed()
        {
            rotatingAround.GetComponent<RotatingAroundObject>().enabled =
                !rotatingAround.GetComponent<RotatingAroundObject>().enabled;
        }
    }
}