using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
    public static T GetOrAdd<T>(this GameObject gameObject) where T : Component
    {
        T component = gameObject.GetComponent<T>();
        return component != null ? component : gameObject.AddComponent<T>();
    }

    public static T OrNull<T>(this T o) where T : Object
    {
        return o != null ? o : null;
    }
}

public static class TransformExtensions
{
    //foreach (var t in transform.Children()) =>  Debug.Log(t.name);
    public static IEnumerable<Transform> Children(this Transform parrent)
    {
        foreach (Transform child in parrent)
        {
            yield return child;
        }
    }
    
    public static void DestroyChildren(this Transform parent)
    {
        for (var i = parent.childCount - 1; i >= 0; i--)
        {
            Object.Destroy(parent.GetChild(i).gameObject);
        }
    }
}

public static class Vector3Extensions
{
    // example : transform.position =  transform.position.With(y: 5);
    public static Vector3 With(this Vector3 vector3, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? vector3.x, y ?? vector3.y, z ?? vector3.z);
    }     
    
    // example : transform.position =  transform.position.Add(x: 1, y: 5);
    public static Vector3 Add(this Vector3 vector3, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(vector3.x + (x ?? 0), vector3.y + (y ?? 0), vector3.z + (z ?? 0));
    }
    
}