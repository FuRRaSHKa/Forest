using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAudioTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            AudioController.current.NearFire(true, gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            AudioController.current.NearFire(false, gameObject);
    }

}
