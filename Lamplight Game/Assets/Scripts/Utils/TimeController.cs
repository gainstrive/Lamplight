using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [Header("Time Control Keybinds:")]
    public KeyCode TimeToggleKey;

    [Header("Slow Time Controls:")]
    public bool SlowTimeEnabled = false;
    public bool IsSlowingTime = false;
    public float TimeScaleMin;
    public float SlowTimeIdleMin;
    public float SlowTimeAmount;
    public float SlowTimeUpdateFrames;

    [Header("Speed Up Time Controls:")]
    public bool SpeedUpTimeEnabled = false;
    public bool IsSpeedingUpTime = false;
    public float TimeScaleMax;
    public float SpeedUpTimeIdleMax;
    public float SpeedUpTimeAmount;
    public float SpeedUpTimeUpdateFrames;

    private void Start()
    {
        // SET DEFAULT VALUES FOR CONTROLLER
        // =================================

        // SLOW TIME CONTROLS:
        SlowTimeEnabled = false;
        IsSlowingTime = false;
        if (TimeScaleMin == 0) {TimeScaleMin = .05f;}
        if (SlowTimeIdleMin == 0) { SlowTimeIdleMin = 0.1f; }
        if (SlowTimeAmount == 0) { SlowTimeAmount = 0.01f; }
        if (SlowTimeUpdateFrames == 0) { SlowTimeUpdateFrames = 0.001f; }

        // SPEED UP TIME CONTROLS:
        SpeedUpTimeEnabled = false;
        IsSpeedingUpTime = false;
        if (TimeScaleMax == 0) { TimeScaleMax = 0.9f; }
        if (SpeedUpTimeIdleMax == 0) { SpeedUpTimeIdleMax = 1; }
        if (SpeedUpTimeAmount == 0) { SpeedUpTimeAmount = 0.01f; }
        if (SpeedUpTimeUpdateFrames == 0) { SpeedUpTimeUpdateFrames = 0.001f; }

    }
    private void Update()
    {
        if (Input.GetKeyDown(TimeToggleKey))
        {
            if (!SlowTimeEnabled)
            {
                SlowTimeEnabled = true;
                IsSlowingTime = true;
                IsSpeedingUpTime = false;
                SpeedUpTimeEnabled = false;
                Debug.Log("Slowing Down Time.");
            }
            else
            {
                Debug.Log("Speeding Up Time.");
                SlowTimeEnabled = false;
                IsSlowingTime = false;
                IsSpeedingUpTime = true;
                SpeedUpTimeEnabled = true;
            }
        }
        if (SlowTimeEnabled)
        {
            StartCoroutine("SlowTime");
        }
        if (SpeedUpTimeEnabled)
        {
            StartCoroutine("SpeedUpTime");
        }
    }
    private IEnumerator SlowTime()
    {
        yield return new WaitForSeconds(SlowTimeUpdateFrames);
        if (IsSlowingTime)
        {
            if (Time.timeScale >= TimeScaleMin)
            {
                Time.timeScale -= SlowTimeAmount;
            }
            else if (Time.timeScale < 0.0)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = SlowTimeIdleMin;
                IsSlowingTime = false;
                StopAllCoroutines();
                Debug.Log("Done.");
            }
        }
        else
        {
        }
    }

    private IEnumerator SpeedUpTime()
    {
        yield return new WaitForSeconds(SpeedUpTimeUpdateFrames);
        if (IsSpeedingUpTime)
        {
            if (Time.timeScale <= TimeScaleMax)
            {
                Time.timeScale += SpeedUpTimeAmount;
            }
            else if (Time.timeScale > 1)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = SpeedUpTimeIdleMax;
                IsSpeedingUpTime = false;
                StopAllCoroutines();
                Debug.Log("Done.");
            }
        }
        else
        {
        }
    }
}
