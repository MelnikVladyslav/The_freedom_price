using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Build", menuName = "Create objects/Build")]
public class Build : ScriptableObject
{
    public string Name;
    public string Type;
    public string Price;

}

[CreateAssetMenu(fileName = "Polk", menuName = "Create objects/Polk")]
public class Army : ScriptableObject {

    public string Name;
    public string Type;
    public string Price;
    public string Hit;
    public string Step;

}