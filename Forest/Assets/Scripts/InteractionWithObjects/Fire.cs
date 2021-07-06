using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject lightObj;

    public Sprite Burning;
    public Sprite unburning;

    public float fireRadius;
    
    public LayerMask custic;
    public LayerMask costerok;

    public bool isOnFire = false;

    private SpriteRenderer spriteRenderer;

    private bool isNearby = false;

    private void Start() {

        spriteRenderer = GetComponent<SpriteRenderer>();

        lightObj.SetActive(false);

    }

    private void Update() {

        if (!isNearby)
            return;

        if (Input.GetAxisRaw("Use") != 0) {

            if (isOnFire) {
                
                Use();
           
            } else {

                TryToIgnite();

            }
            
        }

    }

    private void Use() {

        Collider2D collider = Physics2D.OverlapCircle(transform.position, fireRadius, custic);

        if (collider == null)
            return;

        collider.GetComponent<Grass>().SetFree();

        spriteRenderer.sprite = unburning;

        isOnFire = false;

        gameObject.SetActive(false);

    }

    public void PickupTorch() {

        isNearby = true;

    }

    private void TryToIgnite() {

        Collider2D collider = Physics2D.OverlapCircle(transform.position, fireRadius, costerok);

        if (collider == null)
            return;

        isOnFire = true;

        spriteRenderer.sprite = Burning;

        lightObj.SetActive(true);

    }

    private void OnDrawGizmos() {

        Gizmos.DrawWireSphere(transform.position, fireRadius);

    }

}
