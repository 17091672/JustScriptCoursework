using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{
    List<string> bactTempType = new List<string>() { "Bacteria type","Thermophile", "Extreme Thermophile", "mesophile", "psychrophile" };
    List<string> bactAcidType = new List<string>() { "Bacteria type","Acidophile", "neutrophile", "alkaliphile" };
    List<string> bactOxygenType = new List<string>() { "Bacteria type","Obligate aerobes", "Facultative anaerobes", "Aerotolerant anaerobes", "microaerophiles", "capnophiles" };
    List<string> bactFood = new List<string>() { "Avalability","constant food", "no food" };
    List<string> bactMoisture = new List<string>() { "Concentration","high", "moderate", "low" };
    List<string> bactOxygen = new List<string>() { "Avalability","yes", "no", "little bit", "carbon dioxide instead" };

    public Dropdown dropdown_temp;
    public Dropdown dropdown_acid;
    public Dropdown dropdown_food;
    public Dropdown dropdown_oxygen;
    public Dropdown dropdown_moisture;
    public Dropdown dropdown_oxygenType;
    //to do: put all of the 'public text ...' items into an array so i can use it easier.
    public Text selectBactTempType;
    public Text selectBactAcidType;
    public Text selectBactOxygenType;
    public Text selectBactFood;
    public Text selectBactMoisture;
    public Text selectBactOxygen;

    public void DropdownSelectionIndexChange(int index)
    {
    //to do: .text items selected go into a array when the utton start gowth is clicked
        selectBactTempType.text = bactTempType[index];
        selectBactAcidType.text = bactAcidType[index];
        selectBactOxygenType.text = bactOxygenType[index];
        selectBactFood.text = bactFood[index];
        selectBactMoisture.text = bactMoisture[index];
        selectBactOxygen.text = bactOxygen[index];
    //if (index==0)
    //{
    //to do: make it so that you cant go to the next ecene until this option is chosen.
    //}
    }
    private void Start()
    {
        PopulateList();

    }

    void PopulateList()
    {
        // read values from a file
        dropdown_temp.AddOptions(bactTempType);
        dropdown_acid.AddOptions(bactAcidType);
        dropdown_food.AddOptions(bactFood);
        dropdown_oxygen.AddOptions(bactOxygen);
        dropdown_oxygenType.AddOptions(bactOxygenType);
        dropdown_moisture.AddOptions(bactMoisture);
    }

}
