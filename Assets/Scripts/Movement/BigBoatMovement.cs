using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoatMovement : BaseMovement
{
    void Start()
    {
        rb2d.drag = 2f;
        rb2d.angularDrag = 2f;
    }
}
