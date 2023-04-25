using UnityEngine;
using UnityEngine.Events;

namespace Model
{
    public interface ISceneObject
    {
        public Vector3 Position { get; set; }
        public UnityEvent PositionChange { get; set; }

    }
}