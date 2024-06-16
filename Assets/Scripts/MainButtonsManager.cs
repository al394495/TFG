using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class MainButtonsManager : MonoBehaviour
{
    public Button defaultButton;
    public Button rainButton;
    public Button snowButton;
    public Button fogButton;

    public GameObject rainIntensitySlider;
    public GameObject snowIntensitySlider;
    public GameObject fogIntensitySlider;

    public VisualEffect weather;

    public void OnRainButtonPressed()
    {
        rainIntensitySlider.SetActive(true);
        rainIntensitySlider.GetComponent<Slider>().value = 0;

        snowIntensitySlider.SetActive(false);
        weather.SetInt("SnowRate", 0);
        fogIntensitySlider.SetActive(false);
        weather.SetInt("FogRate", 0);
    }

    public void OnSnowButtonPressed()
    {
        snowIntensitySlider.SetActive(true);
        snowIntensitySlider.GetComponent<Slider>().value = 0;

        rainIntensitySlider.SetActive(false);
        weather.SetInt("RainRate", 0);
        fogIntensitySlider.SetActive(false);
        weather.SetInt("FogRate", 0);
    }

    public void OnFogButtonPressed()
    {
        fogIntensitySlider.SetActive(true);
        fogIntensitySlider.GetComponent<Slider>().value = 0;

        snowIntensitySlider.SetActive(false);
        weather.SetInt("SnowRate", 0);
        rainIntensitySlider.SetActive(false);
        weather.SetInt("RainRate", 0);
    }
}
