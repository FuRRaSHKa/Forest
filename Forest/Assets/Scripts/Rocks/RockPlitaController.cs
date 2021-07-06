using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPlitaController : MonoBehaviour {

    public static RockPlitaController current;

    public int id = 0;
    public int allPliti = 3;

    public int count = 0;

    private void Start() {

        if (current != null)
            Destroy(this);

        current = this;

    }

    public void Increment() {

        count++;

        if (count >= allPliti) {
            
            EventController.current.LeverArm(id);
        
        }

    }

    public void Decrement() {

        if (count <= 0)
            return;

        count--;

        if (count < allPliti) {

            EventController.current.CloseDoor(id);

        }

    }

}
