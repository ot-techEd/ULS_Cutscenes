using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnvironmentManager: MonoBehaviour
{
    public Material milkywaySkybox;

    public void SwapSkyboxMilkyWay()
    {
        RenderSettings.skybox = milkywaySkybox;
    }
}
