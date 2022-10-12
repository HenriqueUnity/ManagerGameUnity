using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="hero",menuName ="Hero/new Hero")]

public class Heroes : ScriptableObject
{
    public int id,power, payday, cost, fatigue,fatiguemax;
    public string heroName;
    
    
}
