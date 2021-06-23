using UnityEngine;

namespace DefaultNamespace
{
    public class DoorHandler : MonoBehaviour
    {
        private Animator animator;

        void Start()
        {
            animator = this.gameObject.GetComponent<Animator>();
        }
        
        void Update()
        {
        }

        public void Trigger()
        {
            if (animator != null)
            {
                animator.SetTrigger("Toggle");
            }
        }
    }
}