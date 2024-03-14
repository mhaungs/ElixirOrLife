using UnityEngine;

namespace XEntity.InventoryItemSystem
{
    //This script is attached to any item that is picked up by the interactor on a single click such as small rocks and sticks.
    //NOTE: The item is only added if the interactor is within the interaction range.
    public class InstantHarvest : MonoBehaviour, IInteractable
    {
        private bool isHarvested = false;

        //The item that will be harvested on click.
        public Item harvestItem;

        //public void OnTriggerEnter(Interactor interactor)
        //{
        //AttemptHarvest(interactor);
        //}

        public void OnTriggerEnter(Collider other)
        {
            // Check if the collider's GameObject has an Interactor component
            Interactor interactor = other.gameObject.GetComponent<Interactor>();
            if (interactor != null)
            {
                // Attempt to harvest if not harvested already
                AttemptHarvest(interactor);
            }
        }

        //The item is instantly added to the inventory of the interactor on interact.
        public void OnClickInteract(Interactor interactor)
        {
            //Attempt to harvest if not harvested already
            AttemptHarvest(interactor);
        }

        public void AttemptHarvest(Interactor harvestor) 
        {
            if (!isHarvested)
            {
                if (harvestor.AddToInventory(harvestItem, gameObject))
                {
                    isHarvested = true;
                }
            }
        }
    }
}
