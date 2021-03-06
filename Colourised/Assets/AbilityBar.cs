using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBar : MonoBehaviour
{
    public GameObject mAbilityButtonPrefab;
    public List<AbilityButton> mAllButton = new List<AbilityButton>();

    public void createbuttons(List<KeyCode> abilityHotkeys /*, player player*/)
    {
        List<AbilityButton> newButtons = new List<AbilityButton>();

        for(int i = 0; i < 4; i++)
        {
            GameObject newButtonObject = Instantiate(mAbilityButtonPrefab, transform);
            AbilityButton abilityButton = newButtonObject.GetComponent<AbilityButton>();

            newButtons.Add(abilityButton);
        }

		mAllButton = newButtons;
    }
}
