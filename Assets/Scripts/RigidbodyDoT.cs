using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins;

public class RigidbodyDoT : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Transform player;
    [SerializeField] private Transform parentPath;
    public PathType pathtype;
    public PathMode mode;

    private void Start()
    {
        player = GetComponent<Transform>();
        Vector3[] pathArray = new Vector3[parentPath.childCount + 1];

        for (int i = 0; i < pathArray.Length - 1; i++)
        {
            pathArray[i] = parentPath.GetChild(i).position;
        }
        pathArray[pathArray.Length - 1] = pathArray[0];
        player.DOPath(pathArray, 5f, pathtype).SetLookAt(.1f).SetLoops(-1);
    }

    private void Update()
    {
       if(Input.GetKey(KeyCode.Space))
        {
            //hareket sağlar
            /*player.transform.DOMove(new Vector3(5, transform.position.y, transform.position.z), .1f);
            player.transform.DOMoveX(-5, .5f);
            player.transform.DOMoveY(transform.position.y + 4, .1f);
            player.transform.DOMoveZ(4, .2f);

            // jump hareketi sağlar.
            player.transform.DOJump(new Vector3(10, 10, transform.position.z), 10, 1 ,.1f);

            //rotasyon sağlar.
            player.transform.DORotate(new Vector3(60, 60, 60), 2f).Loops();
            
            //hedef ya dabelirlenen yere odaklanmasını sağlar.
            player.transform.DOLookAt(new Vector3(target.position.x, target.position.y, target.position.z), .1f, AxisConstraint.X);*/

            

        }


    }
}
