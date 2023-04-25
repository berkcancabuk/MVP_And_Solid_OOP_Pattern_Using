using System;

namespace Model
{
   
    public class BallModel : SceneObject, IFallingItem
    {
        private bool _isActive;
        public event Action<bool> ObjectActiveted;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                ObjectActiveted.Invoke(_isActive);
            } 
        }

        
    }
}

