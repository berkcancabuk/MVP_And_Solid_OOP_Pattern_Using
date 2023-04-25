using System;

namespace Model
{
    public interface IFallingItem: ISceneObject
    {
        public bool IsActive { get; set; }
        public event Action<bool> ObjectActiveted;
    }
}

