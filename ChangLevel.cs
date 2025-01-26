using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jam.GameEvent
{
    [CreateAssetMenu(fileName = "level", menuName ="GameEvents/Levels")]
    public class ChangeLevel : GameEvent
    {
        public string sceneName;

        public override void PerformEvent()
        {
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.Log("Assign scene");
            }
        }

    }
}
