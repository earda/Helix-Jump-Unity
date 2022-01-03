using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    public GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Ad� : " + materialName);

        if(materialName == "Unsafe Color (Instance)")
        {
            //b�l�m yeniden ba�layacak
            UIManager.Instance.Levelfail();
            rb.isKinematic = true ;
        }
        else if(materialName == "Last Ring (Instance)")
        {
            //bir sonraki levela ge�ecek
            UIManager.Instance.LevelComp();
            rb.isKinematic = true;
        }
    }
}
