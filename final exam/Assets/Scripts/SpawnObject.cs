using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : ObjectPlacer
{

    public override void Create()
    {
        base.Create();
        GameObject moonshine = Instantiate(Prefab, ScreenPositionTools.RandomTopOfScreenWorldLocation(Camera), Quaternion.identity);
    }

    public Camera Camera { get; set; }
}
