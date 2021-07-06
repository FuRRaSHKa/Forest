using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketInteraction : Interaction
{

    public Vector3 newLocalPos;

    private Transform player;
    private Water water;

    override protected void StartInteraction()
    {

        transform.SetParent(player);

        transform.localEulerAngles = Vector3.zero;

        transform.localPosition = newLocalPos;

        water.PickupBucket();

        this.enabled = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            water = GetComponent<Water>();

            player = collision.transform.GetChild(0);

            isNearby = true;

        }

    }

}
