using UnityEngine;

[CreateAssetMenu(menuName = "Character/HealthModifier")]
public class CharacterStatHealthModifierSO : ScriptableObject
{
    public virtual void AffectCharacter(GameObject character, float val)
    {
        Health health = character.GetComponent<Health>();
        if (health != null)
        {
            health.AddHealth((int)val);
        }
        else
        {
            Debug.LogError("No Health component found on " + character.name);
        }
    }
}