using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Light", menuName = "Create objects/Build/Light")]
public class Light : Build
{
    public int Dohid;

    void Awake()
    {
        Type = TypeBuild.Lehka;
    }
}

[CreateAssetMenu(fileName = "Big", menuName = "Create objects/Build/Big")]
public class Big : Build
{
    public int ZnuchkaVis;

    void Awake()
    {
        Type = TypeBuild.Big;
    }
}

[CreateAssetMenu(fileName = "Defend", menuName = "Create objects/Build/Defend")]
public class Defend : Build
{
    public int Hit;
    public int Damage;

    void Awake()
    {
        Type = TypeBuild.Defend;
    }
}
