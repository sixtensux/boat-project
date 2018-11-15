using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoatMovement : BaseMovement
{
    void Start()
    {
        rb2d.drag = 0.1f;
        rb2d.angularDrag = 0.1f;
    }
}
