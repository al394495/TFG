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
    public Slider fogAlphaSlider;
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

    public void OnFogAlphaChanged()
    {
        AnimationCurve aCurve = weather.GetAnimationCurve("FogAlpha");

        weather.SetAnimationCurve("FogAlpha", new AnimationCurve(aCurve.keys[0], new Keyframe(aCurve.keys[1].time, fogAlphaSlider.value), new Keyframe(aCurve.keys[2].time, fogAlphaSlider.value), aCurve.keys[3]));
    }
}
