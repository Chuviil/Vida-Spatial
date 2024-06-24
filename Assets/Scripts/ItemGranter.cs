using SpatialSys.UnitySDK;
using UnityEngine;

public class ItemGranter : MonoBehaviour
{
    public void GrantUdlaCoins()
    {
        SpatialBridge.inventoryService.AddItem("ksg76tjohneahsx8ep73l", 25).SetCompletedEvent((response) =>
        {
            Debug.Log("Coins granted!");
        });
    }
}