using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoatMovement : BaseMovement
{
    void Start()
    {
        rb2d.drag = 4.5f;
        rb2d.angularDrag = 4.5f;
    }
}
