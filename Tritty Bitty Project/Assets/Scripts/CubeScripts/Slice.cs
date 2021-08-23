using System;
using RayFire;
using UnityEngine;

namespace CubeScripts
{
    public class Slice : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<RayfireShatter>().Fragment();
        }
    }
}
