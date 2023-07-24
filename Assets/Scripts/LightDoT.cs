using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LightDoT : MonoBehaviour
{
    [SerializeField] Light spotLight;

    private void Start()
    {
        //Işığın gölgesi varsa değerini değiştirir.
        spotLight.DOShadowStrength(.5f, 2f);
        //Işığın DOColor gibi renk değiştirmesini sağlar.
        spotLight.DOBlendableColor(Color.green, 3f);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Işığın rengini 5 saniyede mevcut renginden maviye çevirir.
            spotLight.DOColor(Color.blue, 5f);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            //Işığın yoğunluğunu 3 saniyede istediğimiz değere çıkartır ya da azaltır.
            spotLight.DOIntensity(5f, 3f);
        }        
    }
}
