using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncremenFuction : MonoBehaviour
{
    private Vector3 tempVector;

    private void Vector3(ref Vector3 Start_Vector, Vector3 Increment_Vector, out Vector3 End_Vector)
    {
        Start_Vector += Increment_Vector;
        End_Vector = Start_Vector;
    }
}
