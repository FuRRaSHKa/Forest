using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject windObj;

    public float maximalVolumeOfWind;
    public float maximalVolumeOfMusic;

    private float windBeforePiano;
    private float musicBeforePiano;

    private bool isNearFire;
    private bool isNearPiano;

    private GameObject nearbyFire;
    private GameObject piano;

    private CircleCollider2D pianoTrigger;
    private CircleCollider2D nearbyFireTrigger;

    private AudioSource music;
    private AudioSource wind;

    public static AudioController current;

    private void Awake()
    {
        if (current != null)
            Destroy(this);
        current = this;
    }

    private void Start()
    {
        piano = GameObject.FindGameObjectWithTag("Piano");
        pianoTrigger = piano.GetComponent<CircleCollider2D>();
        music = GetComponent<AudioSource>();
        wind = windObj.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isNearPiano)
            pianoSoundLogick();
        else
        {
            windBeforePiano = wind.volume;
            musicBeforePiano = music.volume;
            WindLogick();
            music.volume = maximalVolumeOfMusic * ((Vector2)(transform.position - wind.transform.position)).magnitude / wind.maxDistance;
        }
    }



    private void WindLogick()
    {
        if (isNearFire)
        {
            wind.volume = maximalVolumeOfWind * (((Vector2)(transform.position - nearbyFire.transform.position)).magnitude - 0.5f) / nearbyFireTrigger.radius;
        }
        else
        {
            wind.volume = maximalVolumeOfWind;
        }
    }

    private void pianoSoundLogick()
    {
        wind.volume = windBeforePiano * (((Vector2)(transform.position - piano.transform.position)).magnitude - 0.5f) / pianoTrigger.radius;
        music.volume = musicBeforePiano * (((Vector2)(transform.position - piano.transform.position)).magnitude - 0.5f) / pianoTrigger.radius;
    }


    public void NearPiano(bool a)
    {
        isNearPiano = a;
    }


    public void NearFire(bool a, GameObject fire)
    {
        isNearFire = a;
        nearbyFire = fire;
        nearbyFireTrigger = fire.GetComponent<CircleCollider2D>();
    }
}
