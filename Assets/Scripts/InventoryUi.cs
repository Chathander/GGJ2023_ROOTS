using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUi : MonoBehaviour
{
    private TextMeshProUGUI fruitText;
    // Start is called before the first frame update
    void Start()
    {
        fruitText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateFruitText(PlayerInventory playerInventory)
    {
        fruitText.text = playerInventory.NumberOfFruits.ToString();
    }
}
