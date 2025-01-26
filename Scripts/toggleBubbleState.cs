using UnityEngine;
namespace GameJam2025
{
    public class ToggleBubbleState : MonoBehaviour {
        [SerializeField]private GameObject gameObject1;
        [SerializeField]private GameObject gameObject2;
    
        public void toggleBubble(GameObject gameObject1, GameObject gameObject2) {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
        }
    }
}
