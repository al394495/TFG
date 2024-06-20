using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class MainButtonsManager : MonoBehaviour
{
    public GameObject rainRateSlider;
    public GameObject rainDirectionSlider;
    public GameObject snowRateSlider;
    public GameObject snowGravitySlider;
    public GameObject fogDistanceSlider;
    public GameObject fogAlphaSlider;

    public VisualEffect weather;

    public AudioSource rain;
    public AudioSource wind;

    public void OnRainButtonPressed()
    {
        rainRateSlider.SetActive(true);
        rainDirectionSlider.SetActive(true);
        rainRateSlider.GetComponent<Slider>().value = 0;
        rainDirectionSlider.GetComponent<Slider>().value = 0;

        rain.mute = false;
        rain.volume = 0;
        wind.mute = false;

        snowRateSlider.SetActive(false);
        snowGravitySlider.SetActive(false);
        weather.SetInt("SnowRate", 0);
        fogDistanceSlider.SetActive(false);
        fogAlphaSlider.SetActive(false);
        weather.SetInt("FogRate", 0);
    }

    public void OnSnowButtonPressed()
    {
        snowRateSlider.SetActive(true);
        snowGravitySlider.SetActive(true);
        snowRateSlider.GetComponent<Slider>().value = 0;
        snowGravitySlider.GetComponent<Slider>().value = -2;

        rain.mute = true;
        wind.mute = false;

        rainRateSlider.SetActive(false);
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

        rain.mute = true;
        wind.mute = true;

        snowRateSlider.SetActive(false);
        snowGravitySlider.SetActive(false);
        weather.SetInt("SnowRate", 0);
        rainRateSlider.SetActive(false);
        rainDirectionSlider.SetActive(false);
        weather.SetInt("RainRate", 0);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
