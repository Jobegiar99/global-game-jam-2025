using Codice.Client.Common;
using UnityEditor;
using UnityEngine;

namespace Jam.GameEvent
{
    public abstract class GameEvent : ScriptableObject
    {
        public abstract void PerformEvent();
    }
}



