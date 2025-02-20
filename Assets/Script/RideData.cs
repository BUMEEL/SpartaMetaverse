using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Rides
{
    public Sprite RideSprite;
    public int RideIndex;
    public string RideName;
    public string RideDes;
    public float RideSpeed;
}

public class RideData : MonoBehaviour
{
    public Rides[] _rides;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}