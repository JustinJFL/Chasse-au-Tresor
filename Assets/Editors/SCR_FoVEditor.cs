using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(SCR_FoV))]
public class SCR_FoVEditor : Editor
{
 void OnSceneGUI()
    {
        SCR_FoV fov = (SCR_FoV)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fov.transform.position, Vector3.up, Vector3.forward, 360, fov.viewRadius);
    
    }
}
