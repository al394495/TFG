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
    public GameObject rainDirectionSlider;
    public GameObject snowIntensitySlider;
    public GameObject snowGravitySlider;
    public GameObject fogDistanceSlider;
    public GameObject fogAlphaSlider;

    public VisualEffect weather;

    public void OnRainButtonPressed()
    {
        rainIntensitySlider.SetActive(true);
        rainDirectionSlider.SetActive(true);
        rainIntensitySlider.GetComponent<Slider>().value = 0;
        rainDirectionSlider.GetComponent<Slider>().value = 0;

        snowIntensitySlider.SetActive(false);
        snowGravitySlider.SetActive(false);
        weather.SetInt("SnowRate", 0);
        fogDistanceSlider.SetActive(false);
        fogAlphaSlider.SetActive(false);
        weather.SetInt("FogRate", 0);
    }

    public void OnSnowButtonPressed()
    {
        snowIntensitySlider.SetActive(true);
        snowGravitySlider.SetActive(true);
        snowIntensitySlider.GetComponent<Slider>().value = 0;
        snowGravitySlider.GetComponent<Slider>().value = -2;

        rainIntensitySlider.SetActive(false);
        rainDirectionSlider.SetActive(false);
        weather.SetInt("RainRate", 0);
        fogDistanceSlider.SetActive(false);
        fogAlphaSlider.SetActive(false);
        weather.SetInt("FogRate", 0);
    }

    public void OnFogButtonPressed()
    {
        fogDistanceSlider.SetActive(true);
        fogAlphaSlider.SetActive(true);
        fogDistanceSlider.GetComponent<Slider>().value = 0;
        fogAlphaSlider.GetComponent<Slider>().value = 0.1f;
        weather.SetInt("FogRate", 15);

        snowIntensitySlider.SetActive(false);
        snowGravitySlider.SetActive(false);
        weather.SetInt("SnowRate", 0);
        rainIntensitySlider.SetActive(false);
        rainDirectionSlider.SetActive(false);
        weather.SetInt("RainRate", 0);
    }
}
