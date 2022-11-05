using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fighter", menuName = "Create objects/Air/Fighter")]
public class Fighter : Air
{
    void Awake()
    {
        Type = TypeAir.Fighter;
    }
}

[CreateAssetMenu(fileName = "Bomber", menuName = "Create objects/Air/Bomber")]
public class Bomber : Air
{
    void Awake()
    {
        Type = TypeAir.Bomber;
    }
}
