using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Garrizon", menuName = "Create objects/Polk/Garrizon")]
public class Garrizon : Polk
{
    void Awake()
    {
        Type = TypePolk.Garrison;
    }
}

[CreateAssetMenu(fileName = "Pihota", menuName = "Create objects/Polk/Pihota")]
public class Pihota : Polk
{
    void Awake()
    {
        Type = TypePolk.Pihota;
    }
}

[CreateAssetMenu(fileName = "Artilery", menuName = "Create objects/Polk/Artilery")]
public class Artilery : Polk
{
    void Awake()
    {
        Type = TypePolk.Artilery;
    }
}

[CreateAssetMenu(fileName = "Tanks", menuName = "Create objects/Polk/Tanks")]
public class Tanks : Polk
{
    public string Bronya;
}

[CreateAssetMenu(fileName = "Motorized", menuName = "Create objects/Polk/Motorized")]
public class Motorized : Polk
{
    void Awake()
    {
        Type = TypePolk.Motorized;
    }
}

[CreateAssetMenu(fileName = "Mechanized", menuName = "Create objects/Polk/Mechanized")]
public class Mechanized : Polk
{
    void Awake()
    {
        Type = TypePolk.Mehanized;
    }
}

[CreateAssetMenu(fileName = "Btr", menuName = "Create objects/Polk/Btr")]
public class Btr : Polk
{
    void Awake()
    {
        Type = TypePolk.Btr;
    }
}