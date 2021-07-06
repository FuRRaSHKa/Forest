using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventController : MonoBehaviour {

    static public EventController current;

    private void Awake() {

        if (current != null)
            Destroy(this);

        current = this;

    }

    public event Action<int> onLeverArmUse;
    public void LeverArm(int id) {

        if (onLeverArmUse != null) 
            onLeverArmUse(id);
        
    
    }

    public event Action<int> onDoorClose;
    public void CloseDoor(int id) {

        if (onDoorClose != null) {
            onDoorClose(id);
        }

    }

}
