 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouse : MonoBehaviour
{
    void Update()
    {
        Faceme();
    }

    private void Faceme()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        Vector2 direction = new Vector2(mouseposition.x - transform.position.x,mouseposition.y - transform.position.y);
        transform.up = direction;
    }
}
