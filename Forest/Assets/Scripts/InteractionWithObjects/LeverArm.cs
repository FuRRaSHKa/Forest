using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverArm : Interaction {

    public Sprite secondSprite;

    public int id = 0;

    private bool isUsed = false;

    override protected void StartInteraction() {

        if (isUsed)
            return;

        EventController.current.LeverArm(id);

        GetComponent<SpriteRenderer>().sprite = secondSprite;

        isUsed = true;

    }

}
