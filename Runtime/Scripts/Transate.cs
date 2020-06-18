using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transate : MonoBehaviour
{
    public Transform _target;


    public void translateUp()
    {
        _target.Translate(0, 0,0.03f);

    }
    public void translateDown()
    {
        _target.Translate(0, 0, -0.03f);
    }
   
}
