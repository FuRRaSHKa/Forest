using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCutscene : MonoBehaviour {
    
    public static FinalCutscene current;
    public Vector3 finalPoint;


    private GameObject player;
   
    private void Awake() {
        if (current != null)
            Destroy(this);
        current = this;
    }

    private void Start() {
    
        player = GameObject.FindGameObjectWithTag("Player");
    
    }

    public void StartFinalCutscene() {
    
        StartCoroutine(Cutscene());
    
    }


    private IEnumerator Cutscene() {

        yield return new WaitForSeconds(2);

        player.GetComponent<PlayerMovement>().enabled =false;

        player.GetComponentInChildren<SpriteRenderer>().sprite = null;

        player.transform.position = finalPoint;

        player.SetActive(false);

        Camera.main.GetComponent<Cinemachine.CinemachineBrain>().enabled = false ;

        Camera.main.transform.position = finalPoint;

        yield return new WaitForSeconds(5);
        Application.Quit();
    }
}
