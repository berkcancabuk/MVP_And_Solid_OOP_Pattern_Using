using System;
using Model;
using UnityEngine;
using View;

namespace Presenter
{
    public class BallPresenter: MonoBehaviour, IBallPresenter
    {
        private IFallingItem _fallingItem;

        private IBallView _view;
        public BallPresenter()
        {
            
        }
        
        public void ShouldDestroy(bool isActive)
        {
            if (!isActive)
            {
                _view.Disable();
            }
        }

        public void Init(IBallView ballView, IFallingItem fallingItem)
        {
            _fallingItem = fallingItem;
            _view = ballView;
            _fallingItem.ObjectActiveted += ShouldDestroy;
            _view.Triggered += Triggered;
        }

        public void Triggered()
        {
            _fallingItem.IsActive = false;
        }
    }
}