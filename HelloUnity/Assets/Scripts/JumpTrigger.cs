using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
      private void OnTriggerEnter(Collider other){
        {
            if (other.gameObject.tag == "Player"){
                Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(0,100,0));

                Destroy(this.gameObject);
            }
        }

    }
}
