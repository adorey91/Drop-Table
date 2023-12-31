using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class dropTable_AdrianDorey : MonoBehaviour
{
    [Header("Chest Types")]
    [SerializeField] private int woodenChest;
    [SerializeField] private int bronzeChest;
    [SerializeField] private int silverChest;
    [SerializeField] private int goldChest;
    [SerializeField] private int platinumChest;
    [SerializeField] private List<string> chestDrops;

    [Header("Wooden Chest")]
    [SerializeField] private int woodenChestCommon;
    [SerializeField] private int woodenChestUncommon;
    [SerializeField] private int woodenChestRare;
    [SerializeField] private int woodenChestEpic;
    [SerializeField] private int woodenChestLegendary;
    [SerializeField] private List<string> woodenChestDrops;

    [Header("Bronze Chest")]
    [SerializeField] private int bronzeChestCommon;
    [SerializeField] private int bronzeChestUncommon;
    [SerializeField] private int bronzeChestRare;
    [SerializeField] private int bronzeChestEpic;
    [SerializeField] private int bronzeChestLegendary;
    [SerializeField] private List<string> bronzeChestDrops;

    [Header("Silver Chest")]
    [SerializeField] private int silverChestCommon;
    [SerializeField] private int silverChestUncommon;
    [SerializeField] private int silverChestRare;
    [SerializeField] private int silverChestEpic;
    [SerializeField] private int silverChestLegendary;
    [SerializeField] private List<string> silverChestDrops;

    [Header("Gold Chest")]
    [SerializeField] private int goldChestCommon;
    [SerializeField] private int goldChestUncommon;
    [SerializeField] private int goldChestRare;
    [SerializeField] private int goldChestEpic;
    [SerializeField] private int goldChestLegendary;
    [SerializeField] private List<string> goldChestDrops;

    [Header("Platinum Chest")]
    [SerializeField] private int platinumChestCommon;
    [SerializeField] private int platinumChestUncommon;
    [SerializeField] private int platinumChestRare;
    [SerializeField] private int platinumChestEpic;
    [SerializeField] private int platinumChestLegendary;
    [SerializeField] private List<string> platinumChestDrops;

    private int randomChest;
    private int randomType;
    private string chestType;

    void Start()
    {
        totalChestCount(); // total chest count updated on start
        chestTypeCount();   // total chest types updated on start
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomChest = Random.Range(0, chestDrops.Count); 

            if (chestDrops[randomChest] == "Wooden Chest ")
            {
                randomType = Random.Range(0, woodenChestDrops.Count);
                chestType = woodenChestDrops[randomType];
            }
            else if (chestDrops[randomChest] == "Bronze Chest ")
            {
                randomType = Random.Range(0, bronzeChestDrops.Count);
                chestType = bronzeChestDrops[randomType];
            }
            else if (chestDrops[randomChest] == "Silver Chest ")
            {
                randomType = Random.Range(0, silverChestDrops.Count);
                chestType = silverChestDrops[randomType];
            }
            else if (chestDrops[randomChest] == "Gold Chest ")
            {
                randomType = Random.Range(0, goldChestDrops.Count);
                chestType = goldChestDrops[randomType];
            }
            else if (chestDrops[randomChest] == "Platinum Chest ")
            {
                randomType = Random.Range(0, platinumChestDrops.Count);
                chestType = platinumChestDrops[randomType];
            }

            Debug.Log("You've found a " + chestDrops[randomChest] + " with a " + chestType);
        }
    }

    private void chestTypeCount()
    {
        woodenCount();
        bronzeCount();
        silverCount();
        goldCount();
        platinumCount();
    }

    private void woodenCount()
    {
        for (int chestAmount = 0; chestAmount < woodenChestCommon; chestAmount++)
        {
            woodenChestDrops.Add("Common Drop ");
        }
        for (int chestAmount = 0; chestAmount < woodenChestUncommon; chestAmount++)
        {
            woodenChestDrops.Add("Uncommon Drop ");
        }
        for (int chestAmount = 0; chestAmount < woodenChestRare; chestAmount++)
        {
            woodenChestDrops.Add("Rare Drop ");
        }
        for (int chestAmount = 0; chestAmount < woodenChestEpic; chestAmount++)
        {
            woodenChestDrops.Add("Epic Drop ");
        }
        for (int chestAmount = 0; chestAmount < woodenChestLegendary; chestAmount++)
        {
            woodenChestDrops.Add("Legendary Drop ");
        }
    } 
    
    private void bronzeCount()
    {
        for (int chestAmount = 0; chestAmount < bronzeChestCommon; chestAmount++)
        {
            bronzeChestDrops.Add("Common Drop ");
        }
        for (int chestAmount = 0; chestAmount < bronzeChestUncommon; chestAmount++)
        {
            bronzeChestDrops.Add("Uncommon Drop ");
        }
        for (int chestAmount = 0; chestAmount < bronzeChestRare; chestAmount++)
        {
            bronzeChestDrops.Add("Rare Drop ");
        }
        for (int chestAmount = 0; chestAmount < bronzeChestEpic; chestAmount++)
        {
            bronzeChestDrops.Add("Epic Drop ");
        }
        for (int chestAmount = 0; chestAmount < bronzeChestLegendary; chestAmount++)
        {
            bronzeChestDrops.Add("Legendary Drop ");
        }
    }
            
    private void silverCount()
    {
        for (int chestAmount = 0; chestAmount < silverChestCommon; chestAmount++)
        {
            silverChestDrops.Add("Common Drop ");
        }
        for (int chestAmount = 0; chestAmount < silverChestUncommon; chestAmount++)
        {
            silverChestDrops.Add("Uncommon Drop ");
        }
        for (int chestAmount = 0; chestAmount < silverChestRare; chestAmount++)
        {
            silverChestDrops.Add("Rare Drop ");
        }
        for (int chestAmount = 0; chestAmount < silverChestEpic; chestAmount++)
        {
            silverChestDrops.Add("Epic Drop ");
        }
        for (int chestAmount = 0; chestAmount < silverChestLegendary; chestAmount++)
        {
            silverChestDrops.Add("Legendary Drop ");
        }
    }
    
    private void goldCount()
    {
        for (int chestAmount = 0; chestAmount < goldChestCommon; chestAmount++)
        {
            goldChestDrops.Add("Common Drop ");
        }
        for (int chestAmount = 0; chestAmount < goldChestUncommon; chestAmount++)
        {
            goldChestDrops.Add("Uncommon Drop ");
        }
        for (int chestAmount = 0; chestAmount < goldChestRare; chestAmount++)
        {
            goldChestDrops.Add("Rare Drop ");
        }
        for (int chestAmount = 0; chestAmount < goldChestEpic; chestAmount++)
        {
            goldChestDrops.Add("Epic Drop ");
        }
        for (int chestAmount = 0; chestAmount < goldChestLegendary; chestAmount++)
        {
            goldChestDrops.Add("Legendary Drop ");
        }
    }
    
    private void platinumCount()
    {
        for (int chestAmount = 0; chestAmount < platinumChestCommon; chestAmount++)
        {
            platinumChestDrops.Add("Common Drop ");
        }
        for (int chestAmount = 0; chestAmount < platinumChestUncommon; chestAmount++)
        {
            platinumChestDrops.Add("Uncommon Drop ");
        }
        for (int chestAmount = 0; chestAmount < platinumChestRare; chestAmount++)
        {
            platinumChestDrops.Add("Rare Drop ");
        }
        for (int chestAmount = 0; chestAmount < platinumChestEpic; chestAmount++)
        {
            platinumChestDrops.Add("Epic Drop ");
        }
        for (int chestAmount = 0; chestAmount < platinumChestLegendary; chestAmount++)
        {
            platinumChestDrops.Add("Legendary Drop ");
        }
    }
            
    private void totalChestCount()
    {
        for (int chestAmount = 0; chestAmount < woodenChest; chestAmount++)
        {
            chestDrops.Add("Wooden Chest ");
        }
        for (int chestAmount = 0; chestAmount < bronzeChest; chestAmount++)
        {
            chestDrops.Add("Bronze Chest ");
        }
        for (int chestAmount = 0; chestAmount < silverChest; chestAmount++)
        {
            chestDrops.Add("Silver Chest ");
        }
        for (int chestAmount = 0; chestAmount < goldChest; chestAmount++)
        {
            chestDrops.Add("Gold Chest ");
        }
        for (int chestAmount = 0; chestAmount < platinumChest; chestAmount++)
        {
            chestDrops.Add("Platinum Chest ");
        }

    }
}
