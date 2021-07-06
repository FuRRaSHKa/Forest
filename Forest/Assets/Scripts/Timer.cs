using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float lengthOfDay = 10; // время в секундах
    public float lengthOfNight = 10;


    public float currentTime;


    public static Timer current;



    private void Awake()
    {
        if (current != null)
        {
            Destroy(this);
        }
        current = this;
        currentTime = 0;
        StartCoroutine(DayAndNightChange());
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
    }

    private IEnumerator DayAndNightChange()
    {
        while (true)
        {
            Debug.Log("Day " + currentTime);
            yield return new WaitForSeconds(lengthOfDay);
            Debug.Log("Night " + currentTime);
            yield return new WaitForSeconds(lengthOfNight);
        }
    }
}