using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instantcer : ScriptableObject
{
    public GameObject prefab;
    public void createInstance()
    {
        Instantiate(prefab);
    }

    public void createInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }


}
