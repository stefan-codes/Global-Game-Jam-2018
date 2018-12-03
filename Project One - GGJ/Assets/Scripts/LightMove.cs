using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour {

    public GameObject player;
    public Light lightUsed;
    public float rad;
    private Vector3 pos;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        try
        {
            pos = player.transform.position;
            lightUsed.transform.position = new Vector3(pos.x,pos.y + 2, pos.z);
            lightUsed.range = RollerBall.Energy/2;

            if (Input.GetKeyUp(KeyCode.UpArrow)) {
                lightUsed.range++;
            }

            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                lightUsed.range--;
            }
        }
        catch
        {
            //
        }
	}
}
