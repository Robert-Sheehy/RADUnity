using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    float currentTime = 0;
    float MAXTIME = 10;
    float ouchTimer = 0, ouchPeriod = 0.2f, ouchMaxTime = 2;
    bool isOuchTimerOn = false;
    int myHealth = 100;
    Renderer ourRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ourRenderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isOuchTimerOn)
        {
            ourRenderer.material.color =
                new Color(
                    Mathf.Abs(Mathf.Sin(ouchTimer * Mathf.PI * 2)),
                    0, 0

                    );
            ouchTimer += Time.deltaTime;
        }




        currentTime += Time.deltaTime;
        if (currentTime > MAXTIME)
            Destroy(gameObject);
    }


    internal void  takeDamage(int amountOfDamage)
    {
        myHealth -= amountOfDamage;
        if (myHealth <=0)
        {
            startOuchEffect();
            Rigidbody myRigidBody = GetComponent<Rigidbody>();
            Destroy(myRigidBody);
            print("Im Dead!!");
        }

        print("You hurt me with " + amountOfDamage.ToString());
    }


    private void startOuchEffect()
    {
        isOuchTimerOn = true;
        ouchTimer = 0;

    }
}
