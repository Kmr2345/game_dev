using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public GameObject Rain;
    public GameObject SnowFall;
    public GameObject ThunderStorm;

    private bool fogEnabled = false;

    void Start()
    {
        if (Rain != null) Rain.SetActive(false);
        if (SnowFall != null) SnowFall.SetActive(false);
        if (ThunderStorm != null) ThunderStorm.SetActive(false);

        RenderSettings.fog = false; 
    }

    public void ToggleRain()
    {
        if (Rain != null)
            Rain.SetActive(!Rain.activeSelf);
    }

    public void ToggleSnow()
    {
        if (SnowFall != null)
            SnowFall.SetActive(!SnowFall.activeSelf);
    }

    public void ToggleThunder()
    {
        if (ThunderStorm != null)
            ThunderStorm.SetActive(!ThunderStorm.activeSelf);
    }

    public void ToggleFog()
    {
        fogEnabled = !fogEnabled;
        RenderSettings.fog = fogEnabled;
    }
}
