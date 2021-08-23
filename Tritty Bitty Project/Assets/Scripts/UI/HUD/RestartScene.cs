using System.Collections.Generic;
using RayFire;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace UI.HUD
{
    public class RestartScene : MonoBehaviour
    {
        [SerializeField] private GameObject cube;
        [SerializeField] private List<RayfireRigid> fragments;

        public void OnRestartPressed()
        {
            
            // RayfireShatter.Destroy(cube);
            cube.SetActive(true);
            // cube.GetComponent<RayfireShatter>().DeleteFragmentsLast();
        }
    }
}