using JetBrains.Annotations;
using UnityEngine;

namespace DefaultNamespace
{
    public class DoorManager : MonoBehaviour
    {
        private DoorHandler entranceDoorHadler;
        private DoorHandler[] components;
        private GameObject player;
        private readonly float maxDistanceForIteract = 5;
        
        void Start()
        {
            components = GameObject.FindObjectsOfType<DoorHandler>();
            player = GameObject.FindWithTag("Player");
        }
        
        void Update()
        {
            if (Input.GetKeyDown("e") && components != null && components.Length>0)
            {
                var handler = GetDoorHandler();
                if (handler == null)
                    return;
                
                handler.Trigger();
            }
        }

        [CanBeNull]
        private DoorHandler GetDoorHandler()
        {
            Vector3? playerPosition = GetPlayerPosition();
            if (playerPosition == null)
                return null;

            float shortestDistance = -1;
            DoorHandler nearestDoorHandler = null;
            
            foreach (var door in components)
            {
                float distance = Vector3.Distance(door.transform.position, playerPosition.Value);

                if (shortestDistance < 0 || distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearestDoorHandler = door;
                }
            }

            if (shortestDistance <= maxDistanceForIteract && shortestDistance >= 0 && nearestDoorHandler != null)
                return nearestDoorHandler;
            else
                return null;
        }

        private Vector3? GetPlayerPosition()
        {
            if (player != null)
            {
                return player.transform.position;
            }
            else
            {
                return null;
            }
        }
    }
}