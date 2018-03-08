﻿using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {

    public Transform player;

	void Start () {
	
	}


	void Update () {

        if (Vector3.Distance(player.position, this.transform.position) < 10) 
        {
            Vector3 direction = player.position - this.transform.position;
            

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                            Quaternion.LookRotation(direction), 0.1f); 

            if (direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.05f); 
            }

        }

    }
}

