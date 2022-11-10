using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysics : MonoBehaviour
{

    Rigidbody ourRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    { 


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidBody.AddExplosionForce(1000,transform.position+ Vector3.down+ 2* Vector3.back,3);

        }
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject objectHit = collision.gameObject;
        healthScript objectHitHealth = objectHit.GetComponent<healthScript>();
        if (objectHitHealth)
        {
            objectHitHealth.takeDamage(20);
        }
        print("Ouch");
    }


}
