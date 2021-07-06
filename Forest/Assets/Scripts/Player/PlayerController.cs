using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour { 

    private void Update() {

    

        
    
    }

    //IEnumerator SetFire() {
    
    //    bool isFireInZone = false;
    //    GameObject currentFire = FirePool.current.GiveFire();
    //    SpriteRenderer fireGFX = currentFire.GetComponentInChildren<SpriteRenderer>();
        
    //    while (true) {
    //        Vector3 cam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        currentFire.transform.position = new Vector2(cam.x, cam.y);

    //        if ((currentFire.transform.position - this.transform.position).sqrMagnitude <= rangeOfSettingFire * rangeOfSettingFire) //Проверка на расстояние от персонажа
    //        {
    //            isFireInZone = true;
    //            fireGFX.color = Color.green;
    //        } else {
    //            isFireInZone = false;
    //            fireGFX.color = Color.red;
    //        }

    //        if (Input.GetAxisRaw("Fire1") == 1 && isFireInZone) //проверка на нажатие кнопки и радиус
    //        {
    //            fireGFX.color = Color.white;
    //            countOfWoodPieces -= woodPiecesForFire;
    //            settingUpFire = false;
    //            break;
    //        }

    //        if (Input.GetKeyDown(KeyCode.Escape)) //Отмена костра
    //        {
    //            currentFire.SetActive(false);
    //            settingUpFire = false;
    //            break;
    //        }

    //        yield return new WaitForFixedUpdate();
    //    }
    
    //}

    //private void OnDrawGizmos() {
    
    //    Gizmos.DrawWireSphere(transform.position, rangeOfSettingFire);
  
    //}
}
