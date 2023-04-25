using UnityEngine;
using UnityEngine.Events;

namespace Model
{
    public abstract class SceneObject : MonoBehaviour,ISceneObject
    {
        private Vector3 _position;

        public UnityEvent PositionChange { get; set; }

        public Vector3 Position
        {
            get => _position;
            set
            {
                _position = value;
                PositionChange.Invoke();
            }
        }
    }
}

