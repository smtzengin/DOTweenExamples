using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraDoT : MonoBehaviour
{
    float shakeStrength = 2f;
    int vibrato = 10;
    float randomness = 90f;


    private void Start()
    {
        //Camera'nın açısını değiştirir.
        //Camera.main.DOAspect(2f, 3f);

        //Camera'nın background rengini istediğimiz duration'da değiştirir.
        Camera.main.DOColor(Color.green, 3f);

        //Camera'nın Far ayarını değiştirir.
        //Camera.main.DOFarClipPlane(2000f, 3f);

        //Camera'nın Near ayarını değiştirir.
        //Camera.main.DONearClipPlane(.4f, 3f);

        //Camera'nın FOV ayarını değiştirir.
        Camera.main.DOFieldOfView(75f, 3f);

        //Camera eğer Orthographic ayarında ise değişkenin değerini değiştirir.
        //Camera.main.DOOrthoSize(10f, 3f);

        //Camera'nın Rect ayarını değiştirir.
        //Camera.main.DORect(new Rect(1,1,1,1), 3f);
               

    }

    private void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
           //Camera pozisyonunun sallanma efekti yapmasını sağlar
           Camera.main.DOShakePosition(2f, shakeStrength,vibrato,randomness,true,ShakeRandomnessMode.Full);         
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            //Camera rotasyonunun sallanma efekti yapmasını sağlar
            Camera.main.DOShakeRotation(2f, shakeStrength, vibrato, randomness, true, ShakeRandomnessMode.Harmonic);
        }
    }
}
