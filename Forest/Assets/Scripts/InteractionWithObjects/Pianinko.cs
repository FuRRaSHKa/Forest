using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pianinko : Interaction {

    public int id = 3;

    public float timeToDeactivate = 2;

    public int index;

    public AudioClip up;
    public AudioClip left;
    public AudioClip right;
    public AudioClip down;

    public int[] key;

    

    private float timer;

    private AudioSource audioSource;

    private void Start() {

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(PlayPianinka());

    }

    private void Update() {

        if (timer > 0)
            timer -= Time.deltaTime;

    }


    private void Win() {

        EventController.current.LeverArm(id);

    }

    IEnumerator PlayPianinka() {

        index = 0;

        while (true) {

            if (timer <= 0) {

                index = 0;

            }

            if (index == key.Length) {

                Win();

                yield break;

            }

            if (Input.GetKeyDown(KeyCode.UpArrow)) {

                audioSource.clip = up;
                audioSource.Play();

                if (key[index] == 1) {

                    index++;

                    timer = timeToDeactivate;

                } else {

                    index = 0;

                    timer = 0;
                }

                yield return new WaitForSeconds(.2f);
                continue;

            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) {

                audioSource.clip = down;
                audioSource.Play();

                if (key[index] == 4) {

                    index++;

                    timer = timeToDeactivate;

                } else {

                    index = 0;

                    timer = 0;

                }

                yield return new WaitForSeconds(.2f);
                continue;

            }

            if (Input.GetKeyDown(KeyCode.LeftArrow)) {

                audioSource.clip = left;
                audioSource.Play();

                if (key[index] == 2) {

                    timer = timeToDeactivate;

                    index++;

                } else {

                    timer = 0;

                    index = 0;

                }

                yield return new WaitForSeconds(.2f);
                continue;

            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) {

                audioSource.clip = right;
                audioSource.Play();

                if (key[index] == 3) {

                    timer = timeToDeactivate;

                    index++;

                } else {

                    timer = 0;

                    index = 0;

                }

                yield return new WaitForSeconds(.2f);
                continue;

            }

            yield return null;

        }
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
            AudioController.current.NearPiano(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            AudioController.current.NearPiano(false);
    }



}
