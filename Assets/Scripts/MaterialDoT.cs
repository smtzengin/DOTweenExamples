using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MaterialDoT : MonoBehaviour
{
    [SerializeField] Material material;

    [SerializeField] Gradient gradient;
    private void Start()
    {
        //Materyalın rengini değiştirmeye yarar.
        material.DOColor(Color.blue, 2f);

        //Eğer materyal'in rendering modu fade ise alpha değerini düşürür.
        //material.DOFade(2f, 2f);

        //materyale gradient renk geçişi efekti vermesini sağlar
        material.DOGradientColor(gradient, 2f);

        //materyalin offset değerini değiştirir
        material.DOOffset(new Vector2(1, 1), 2f);
        //materyalin tiling değerini değiştirir
        material.DOTiling(new Vector2(1, 1), 2f);
    }
}
