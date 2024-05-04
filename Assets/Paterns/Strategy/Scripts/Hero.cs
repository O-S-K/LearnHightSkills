using UnityEngine;

public class Hero : MonoBehaviour
{
    public SpellStratery[] spellStratery;
    public Transform spellOrigin;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spellStratery[0].CastSpell(spellOrigin);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spellStratery[1].CastSpell(spellOrigin);
        }
    }
}