using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("touching");
                GameObject particleClone = Instantiate(particle, transform.position, Quaternion.identity) as GameObject;
                // TODO: GET THE PARTICLES TO FOLLOW THE FINGER
                Destroy(particleClone, 3);
            }
        }
    }
}
