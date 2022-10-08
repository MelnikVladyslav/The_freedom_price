using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Light", menuName = "Create objects/Polk/Tanks/Light")]
public class TanksLight : Tanks
{
    void Awake()
    {
        Type = TypePolk.LightTanks;
    }
}

[CreateAssetMenu(fileName = "Medium", menuName = "Create objects/Polk/Tanks/Medium")]
public class TanksMedium : Tanks
{
    void Awake()
    {
        Type = TypePolk.MediumTanks;
    }
}

[CreateAssetMenu(fileName = "Heavy", menuName = "Create objects/Polk/Tanks/Heavy")]
public class TanksHeavy : Tanks
{
    void Awake()
    {
        Type = TypePolk.HeavyTanks;
    }
}