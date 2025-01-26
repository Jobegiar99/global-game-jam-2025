using UnityEngine;
using Jam.GameEvent;

namespace Jam.GameEvent
{
    public class InputListener : MonoBehaviour
    {
        public GameEvent changeLevel;
        public KeyCode key = KeyCode.E;

        private void Update()
        {
            if (Input.GetKeyDown(key))
            {
        
                if (changeLevel == null)
                {
                    Debug.Log("Assign Scene");
                }
                else
                {
                    changeLevel.PerformEvent();
                }
               
            }
        }
    }
}

