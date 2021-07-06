using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInteraction : MonoBehaviour {

    public Vector3 newLocalPos;
    public float radius;
    public LayerMask rockLayer;

    private Transform rock;

    private bool isOnHands = false;

    private void StartInteraction() {

        Collider2D collider = Physics2D.OverlapCircle(transform.position, radius, rockLayer);

        if (collider == null)
            return;

        rock = collider.transform;

        rock.SetParent(transform);

        rock.localEulerAngles = Vector3.zero;

        rock.localPosition = (Vector3)newLocalPos;

        isOnHands = true;

    }

    private void PlaceOnEarth() {

        rock.SetParent(null);

        rock.position = transform.position;

        rock = null;

        isOnHands = false;

    }

    private void Update() {

        if (isOnHands) {

            if (Input.GetAxis("Use") != 0) {

                PlaceOnEarth();

                return;

            }

        } else {

            if (Input.GetAxis("Interaction") != 0) {

                StartInteraction();

           

            }

        }



    }


}