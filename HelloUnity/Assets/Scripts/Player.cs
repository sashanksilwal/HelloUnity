using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float Speed = 10.0f;

    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        if (rb == null){
            rb = GetComponent<Rigidbody>();
        }
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ranDir = Random.onUnitSphere * Speed;

        rb.AddForce(new Vector3(ranDir.x,0, ranDir.z));
    }


    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Obstacle")){
            Debug.Log("Collision Enter"+collision.gameObject.name);
            meshRenderer.material.color = collision.gameObject.GetComponent<MeshRenderer>().material.color;
        }
    }

    private void OnCollisionStay(Collision collision){
        Debug.Log("Collision Stay"+collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision){
        Debug.Log("Collision Exit"+collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log("Trigger Enter"+other.gameObject.name);

    }
     private void OnTriggerStay(Collider other){
        Debug.Log("Trigger Exit"+other.gameObject.name);

    }
     private void OnTriggerExit(Collider other){
        Debug.Log("Trigger Exit"+other.gameObject.name);

    }
}
