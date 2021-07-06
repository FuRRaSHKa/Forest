using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

    public LeverArm leverArmToBlock;

    private void Start() {

        leverArmToBlock.enabled = false;

    }

    public void SetFree() {

        leverArmToBlock.enabled = true;

        GetComponent<SpriteRenderer>().enabled = false;

        this.enabled = false;

    }

}
