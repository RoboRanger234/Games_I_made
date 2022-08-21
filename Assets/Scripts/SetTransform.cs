using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 v1 = new Vector3(0f, 0f, 0f);
    Vector3 SetPos(float x, float y, float z)
    {
        v1 = new Vector3(x, y, z);
        return transform.localPosition = v1;
    }
    public void setLocalScale(float x, float y, float z)
    {
        transform.localScale = new Vector3(x, y, z);
    }
    public void setAngle(float x, float y, float z)
    {
        transform.localEulerAngles = new Vector3(x, y, z);
    }
}
/*public class Mover
{
    void MoveForward()
    {
        transform t = GetComponent<transform>();
        for (int i = 0; i < 10; i++)
        {
            t.localPosition = Vector3.forward;
        }
    }
    void MoveBackWard()
    {
        for (int i = 0; i < 10; i++)
        {
            t.localPosition = Vector3.back;
        }
    }
}*/
