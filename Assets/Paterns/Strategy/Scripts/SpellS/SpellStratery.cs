using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public abstract class SpellStratery : ScriptableObject
{
    public int levelUpgrade = 0;
    public abstract void CastSpell(Transform origin);
    public abstract void UpGrade();
}