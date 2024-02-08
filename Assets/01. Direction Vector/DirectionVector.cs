using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AxisType
{
    XYZ,
    XY,
    XZ,
    YZ
}

public static class Extension
{
    public static Vector3 DirectionVector(this Transform transform, in Vector3 targetPoint, AxisType axisType = AxisType.XYZ)
    {
        Vector3 dir = targetPoint - transform.position;

        if (axisType == AxisType.XY)
        {
            dir.z = 0;
        }
        else if (axisType == AxisType.XZ)
        {
            dir.y = 0;
        }
        else if (axisType == AxisType.YZ)
        {
            dir.x = 0;
        }

        return dir;
    }
}
