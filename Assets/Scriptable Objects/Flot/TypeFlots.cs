using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Submarine", menuName = "Create objects/Flot/Submarine")]
public class Submarine : Flot
{
    void Awake()
    {
        Type = TypeFlot.Submarine;
    }
}

[CreateAssetMenu(fileName = "Esminec", menuName = "Create objects/Flot/Esminec")]
public class Esminec : Flot
{
    void Awake()
    {
        Type = TypeFlot.Esminec;
    }
}

[CreateAssetMenu(fileName = "Kreyser", menuName = "Create objects/Flot/Kreyser")]
public class Kreyser : Flot
{
    void Awake()
    {
        Type = TypeFlot.Kreyser;
    }
}

[CreateAssetMenu(fileName = "Linkor", menuName = "Create objects/Flot/Linkor")]
public class Linkor : Flot
{
    void Awake()
    {
        Type = TypeFlot.Linkor;
    }
}

[CreateAssetMenu(fileName = "Airship", menuName = "Create objects/Flot/Airship")]
public class Airship : Flot
{
    void Awake()
    {
        Type = TypeFlot.Airship;
    }
}
