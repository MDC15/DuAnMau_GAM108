using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// A static class providing helper methods for various common tasks in Unity.
/// </summary>
public static class Helpers
{
    private static Camera _camera;
    private static readonly Dictionary<float, WaitForSeconds> WaitDictionary = new();

    /// <summary>
    /// Gets the main camera in the scene.
    /// </summary>
    /// <returns>The main camera in the scene.</returns>
    public static Camera Camera
    {
        get
        {
            if (_camera == null) _camera = Camera.main;
            return _camera;
        }
    }

    /// <summary>
    /// Gets a WaitForSeconds object for the specified time, caching it for efficiency.
    /// </summary>
    /// <param name="time">The duration in seconds for the WaitForSeconds object.</param>
    /// <returns>A WaitForSeconds object for the specified time.</returns>
    public static WaitForSeconds GetWaitForSeconds(float time)
    {
        if (WaitDictionary.TryGetValue(time, out var wait))
            return wait;

        WaitDictionary[time] = new WaitForSeconds(time);
        return WaitDictionary[time];
    }

    /// <summary>
    /// Deletes all children of the specified transform.
    /// </summary>
    /// <param name="t">The transform whose children should be deleted.</param>
    public static void DeleteChildren(this Transform t)
    {
        foreach (Transform child in t)
            Object.Destroy(child.gameObject);
    }
}
