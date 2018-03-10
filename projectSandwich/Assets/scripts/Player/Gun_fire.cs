using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_fire : MonoBehaviour {

    //Gets the Transform of a object put in via unity editor
    public Transform parent;
    
    //Prefab used in instantiate below
    public GameObject player_bullet;

    //Declare float for the rate of fire of 'player_bullet'
    public float fireRate = 3;
    
    //float that is used to compare against Time.time
    private float nextFire;

    private void FixedUpdate()
    {
        if (globalVariables.Instance.GameOn && globalVariables.Instance.InSubMenu == false)
        {
            //If statement that checks two things, if the user has mouse1 held down amd if the gametime is greater than nextFire
            // if both are met, it adds gametime and the delcared 'fireRate' to nextfire then it clones the 'player_bullet' prefab at the declared parents position and parents rotation
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(player_bullet, parent.position, parent.transform.rotation);
            }
        }  
    }
}
