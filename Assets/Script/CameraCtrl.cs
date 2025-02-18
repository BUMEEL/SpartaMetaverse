using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public GameObject Target;
    public float LerpTime = 5.0f;
    public Color BGC;

    void Start()
    {
        Target = GameObject.Find("Player");
        this.gameObject.GetComponent<Camera>().backgroundColor = BGC;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 TargetPos = new Vector3(Target.transform.position.x, Target.transform.position.y , Target.transform.position.z - 10);
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * LerpTime);
    }
}