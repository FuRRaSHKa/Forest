using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

    public LayerMask ozerko;

    public Costeroc costeroc;
    public GameObject plauerLight;

    public Sprite full;
    public Sprite empty;

    public float waterRadius;

    public bool isOnHand = false;

    private SpriteRenderer spriteRenderer;

    private bool isWatering = false;
    private bool costerocDown = false;
    private bool playerDown = false;


    private void Start() {

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void Update() {

        if (!isOnHand)
            return;

        if (costerocDown && playerDown) {

            FinalCutscene.current.StartFinalCutscene();

        }

        if (Input.GetAxisRaw("Use") != 0) {
            

            if (isWatering) {

                
                Use();
            
            } else {
                
                TrytoWater();
            
            }

        }




    }

    public void PickupBucket() {

        isOnHand = true;

    }

    private void TrytoWater() {

        Collider2D collider = Physics2D.OverlapCircle(transform.position, waterRadius, ozerko);

        

        if (collider == null)
            return;



        isWatering = true;

        spriteRenderer.sprite = full;


    }

    private void Use() {

        if (!costerocDown) {

            if ((transform.position - costeroc.transform.position).magnitude < waterRadius) {

                costeroc.TurnOff();

                costerocDown = true;

                spriteRenderer.sprite = empty;

                isWatering = false;
                return;

            }

        }

        if (!playerDown) {

            plauerLight.SetActive(false);
            playerDown = true;
            spriteRenderer.sprite = empty;
            isWatering = false;
        }

    }

}
