using System.Collections.Generic;
using InputManager;
using RayFire;
using UnityEditor;
using UnityEngine;

namespace CubeScripts
{
    public class Fragments : MonoBehaviour
    {
        private Camera _mainCamera;
        private RayfireShatter _cubeShatter;
        private RayfireRigid _cubeRigid;
        private List<RayfireRigid> a = new List<RayfireRigid>();

        private void Awake()
        {
            InputSystem.OnTouchOrClick += FragmentsProcess;
            _mainCamera = Camera.main;
            _cubeShatter = this.GetComponent<RayfireShatter>();
            _cubeRigid = this.GetComponent<RayfireRigid>();
        }


        private void FragmentsProcess(InputSystem.SwipeData obj)
        {
            _cubeRigid.Demolish();
            
            
            // _cubeShatter.showCenter = true;
            // _cubeShatter.centerPosition = obj.Hit.point - new Vector3(0, 0.5f, 0);
            // _cubeShatter.Fragment();
            // //Debug.Log(_cubeShatter.rootChildList[0].GetChild(0).name);
            //
            // for (int i = 0; i < _cubeShatter.rootChildList[0].childCount; i++)
            // {
            //     a.Add(_cubeShatter.rootChildList[0].GetChild(i).GetComponent<RayfireRigid>());
            // }
            //
            // RayfireShatter.CopyRootMeshShatter(GetComponent<RayfireRigid>(), a);
            //
            // gameObject.SetActive(false);
            // //Destroy(gameObject);
        }
    }
}