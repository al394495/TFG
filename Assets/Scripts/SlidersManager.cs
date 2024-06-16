using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class SlidersManager : MonoBehaviour
{
    public VisualEffect weather;

    public Slider rainIntensitySlider;
    public Slider snowIntensitySlider;
    public Slider fogIntensitySlider;
    public void OnRainIntensityChanged()
    {
        weather.SetInt("RainRate", (int) rainIntensitySlider.value);
    }

    public void OnSnowIntensityChanged()
    {
        weather.SetInt("SnowRate", (int)snowIntensitySlider.value);
    }

    public void OnFogIntensityChanged()
    {
        weather.SetInt("FogRate", (int)fogIntensitySlider.value);
    }
}
