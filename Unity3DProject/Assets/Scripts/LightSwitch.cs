using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class LightSwitch : MonoBehaviour
    {
        private Light[] lights;
        
        private void Start()
        {
            lights = GameObject.FindObjectsOfType<Light>();
        }

        private void Update()
        {
            if (Input.GetKeyDown("l") && lights != null && lights.Length>0)
            {
                foreach (var light in lights)
                {
                    light.intensity = light.intensity == (float)1.2 ? (float)0 : (float)1.2;
                }
            }
        }
    }
}