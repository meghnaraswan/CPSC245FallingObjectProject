using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject Prefab;

    public virtual void Create(Vector3 position)
    {
        GameObject newObject = Instantiate(Prefab, position, Quaternion.identity);

    }

    public virtual void Create()
    {

    }
}
