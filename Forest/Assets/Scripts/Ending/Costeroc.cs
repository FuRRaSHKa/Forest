using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Costeroc : MonoBehaviour {

    public Sprite newSprite;

    public GameObject old;
    public GameObject Another;
    public GameObject lightl;

    public void TurnOff() {



        Another.SetActive(true);
        old.SetActive(false);
        lightl.SetActive(false);

        GetComponent<Animator>().enabled = false;
    }


}
