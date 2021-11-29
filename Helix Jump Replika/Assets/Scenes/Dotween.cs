using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Dotween : MonoBehaviour
{
    public GameObject prefab;
    public Ease easeType;
    public LoopType looptype;
    public float duration;
    public int loopCount;
    private void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(0);
          //  transform.DOJump(new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), 5, 1, 1).SetEase(Ease.InCubic);
            transform.DORotate(new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y+180,transform.localEulerAngles.z),duration).
                SetEase(easeType).
                OnStart(()=>
                {
                    var obj = Instantiate(prefab, transform.position, Quaternion.identity);
                    obj.AddComponent<BoxCollider>();
                    obj.AddComponent<Rigidbody>();
                    var rb = obj.GetComponent<Rigidbody>();
                    rb.useGravity = true;
                    rb.AddForce(new Vector3(0,1,Random.Range(-.5f,2)) * 5,ForceMode.Impulse);
                })
                .OnComplete(()=> 
                {
                    Destroy(gameObject);

                });
        
        }
    }
}
