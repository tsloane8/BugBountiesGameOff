using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAim : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var hit : RaycastHit;
            if (Physics.Raycast(ray, hit, 100))
            {
                // Get your player object's position (could be any way, this is just one possible way)
                var playerT = GameObject.FindWithTag("Player").transform;
                // Now you have where your player is and a 3D point the mouse is over
                Debug.DrawLine(playerT.position, hit.point);
            }
        }
    }
}
