using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Jumps the game object to the mouse location on left mouse down
/// </summary>
public class Jumper : MonoBehaviour
{
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // on left mouse down, jump to mouse
        if (Input.GetMouseButtonDown(0))
        {
            // calculate mouse world position
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // move sprite to mouse location
            transform.position = worldPosition;
        }
	}
}
