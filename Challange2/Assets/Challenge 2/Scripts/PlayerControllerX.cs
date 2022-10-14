using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float slowerFire = 1;

    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && slowerFire <= 0)

        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            slowerFire = 1;
        }
        if (slowerFire >= 0)
        { 

        slowerFire -= Time.deltaTime;
        }
    }
}
