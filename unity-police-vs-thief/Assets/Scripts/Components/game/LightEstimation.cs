using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(Light))]
public class LightEstimation : MonoBehaviour
{
    public ARCameraManager ARCameraManager;
    private Light _light;

    private void Start()
    {
        ARCameraManager.frameReceived += FrameReceived;

        _light = GetComponent<Light>();
    }

    private void FrameReceived(ARCameraFrameEventArgs args)
    {
        ARLightEstimationData lightEstimation = args.lightEstimation;

        if (lightEstimation.averageBrightness.HasValue)
            _light.intensity = lightEstimation.averageBrightness.Value;

        if (lightEstimation.averageColorTemperature.HasValue)
            _light.colorTemperature = lightEstimation.averageColorTemperature.Value;

        if (lightEstimation.colorCorrection.HasValue)
            _light.color = lightEstimation.colorCorrection.Value;

        if (lightEstimation.mainLightDirection.HasValue)
            _light.transform.rotation = Quaternion.LookRotation(lightEstimation.mainLightDirection.Value);

        if (lightEstimation.mainLightColor.HasValue)
            _light.color = lightEstimation.mainLightColor.Value;

        if (lightEstimation.mainLightIntensityLumens.HasValue)
            _light.intensity = lightEstimation.averageMainLightBrightness.Value;

        if (lightEstimation.ambientSphericalHarmonics.HasValue)
        {
            RenderSettings.ambientMode = AmbientMode.Skybox;
            RenderSettings.ambientProbe = lightEstimation.ambientSphericalHarmonics.Value;
        }
    }
}
