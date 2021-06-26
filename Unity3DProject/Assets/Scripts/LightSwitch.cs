using System;
using System.Linq;
using UnityEngine;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class LightSwitch : MonoBehaviour
    {
        private List<Light> lights;
        
        private void Start()
        {
            lights = GameObject.FindObjectsOfType<Light>().Where(a=> !a.tag.Contains("DL")).ToList();
        }

        private void Update()
        {
            if (Input.GetKeyDown("l") && lights != null && lights.Count>0)
            {
                foreach (var light in lights)
                {
                    light.intensity = light.intensity == (float)1.2 ? (float)0 : (float)1.2;
                }
            }
        }
    }
}