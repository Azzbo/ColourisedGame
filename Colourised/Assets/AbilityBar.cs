using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBar : MonoBehaviour
{
    public Gameobject mAbilityButtonPrefab;
    public List<AbilityButton> mAllButton = new List<AbilityButton>();

    public void createbuttons(List<KeyCode> abilityHotkeys, player player)
    {
        List<AbilityButton> newButtons = new List<AbilityButton>();

        for(int i = 0; i < 4; i++)
        {
            GameOject newButtonObject = Instantiate(mAbilitiyButtonPrefab, transform);
            AbilityButton abilityButton = newButtonObject.Getcomponent<AbilityButton>();

            newButtons.Add(abilityButton);
        }

		mAllButton = newButtons;
    }
}
