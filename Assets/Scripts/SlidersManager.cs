using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class SlidersManager : MonoBehaviour
{
    public VisualEffect weather;

    public Slider rainIntensitySlider;
    public Slider rainDirectionSlider;
    public Slider snowIntensitySlider;
    public Slider snowGravitySlider;
    public Slider fogDistanceSlider;
    public void OnRainIntensityChanged()
    {
        weather.SetInt("RainRate", (int) rainIntensitySlider.value);
    }

    public void OnRainDirectionChanged()
    {
        weather.SetFloat("RainDirection", rainDirectionSlider.value);
    }

    public void OnSnowIntensityChanged()
    {
        weather.SetInt("SnowRate", (int)snowIntensitySlider.value);
    }

    public void OnSnowGravityChanged()
    {
        weather.SetFloat("SnowGravity", snowGravitySlider.value);
    }

    public void OnFogDistanceChanged()
    {
        weather.SetFloat("FogDistance", fogDistanceSlider.value);
    }
}
