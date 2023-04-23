using System;

namespace View
{
    public interface IBallView
    {
        public event Action Triggered;
        void Disable();
    }
}