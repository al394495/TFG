using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class SlidersManager : MonoBehaviour
{
    public VisualEffect weather;

    public Slider rainRateSlider;
    public Slider rainDirectionSlider;
    public Slider snowRateSlider;
    public Slider snowGravitySlider;
    public Slider fogDistanceSlider;
    public Slider fogAlphaSlider;

    public AudioSource rain;

    public void OnRainRateChanged()
    {
        weather.SetInt("RainRate", (int) rainRateSlider.value);

        rain.volume =  rainRateSlider.value / rainRateSlider.maxValue;
    }

    public void OnRainDirectionChanged()
    {
        weather.SetFloat("RainDirection", rainDirectionSlider.value);
    }

    public void OnSnowRateChanged()
    {
        weather.SetInt("SnowRate", (int)snowRateSlider.value);
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
