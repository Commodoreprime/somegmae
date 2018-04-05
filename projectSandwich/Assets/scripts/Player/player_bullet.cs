using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bullet : MonoBehaviour {

    //Public variables, pretty self-explanitory if you look at where they are used
    public float speed = 10;
    public float increaseAmmount = 2;

    //A Vector3 declare so the update function can translate properly despite uisng only 1 of the 3 axis \_(|:>)_/
    private Vector3 pos;

    void FixedUpdate () 
	{
		if (globalVariables.Instance.GameOn == true) 
		{
		//Took a few tries to get the bullet to fly in the direction of the gun but eventually got it working using transform.Translate . How?
		//Well, Space.Self is when unity uses an objects local axis instead of the global axis. So when it is instantiated (refer to 'Gun_fire.cs') 
		//It gets the same position and rotation of a declared parent (again, refer to 'Gun_fire.cs') then, since Space.Self is declared, position is increased on the LOCAL X axis
			transform.Translate(pos * speed, Space.Self);
			//Just increases the x axis in the pos Vector3 declaration
			pos.x = pos.x + increaseAmmount;
		}
    }

    private void Update()
    {
        //Just a cleanup statement so the game dont lag to death
        if((transform.position.x > 1000 || transform.position.x < -1000))
        {
            Destroy(gameObject);
        }
    }
}
