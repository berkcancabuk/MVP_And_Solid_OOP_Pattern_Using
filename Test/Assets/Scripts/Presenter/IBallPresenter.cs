using Model;
using View;

namespace Presenter
{
    public interface IBallPresenter
    {
        public void Triggered();
        public void ShouldDestroy(bool isDestroyed);
        public void Init(IBallView ballView,IFallingItem fallingItem);
    }
}