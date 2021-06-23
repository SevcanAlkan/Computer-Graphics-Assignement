using UnityEngine;

namespace DefaultNamespace
{
    public class DoorManager : MonoBehaviour
    {
        public GameObject EntranceDoor;

        private DoorHandler entranceDoorHadler;
        
        void Start()
        {
            entranceDoorHadler = EntranceDoor.GetComponent<DoorHandler>();
        }
        
        void Update()
        {
            if (Input.GetKeyDown("e"))
            {
                entranceDoorHadler.Trigger();
            }
        }
    }
}