using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        t.localEulerAngles = t.localEulerAngles + new Vector3(0, Time.deltaTime * 120.0f, 0);
    }

    Transform t;
}
