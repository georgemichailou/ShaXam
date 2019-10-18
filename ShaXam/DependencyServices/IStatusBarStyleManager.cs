using System;
namespace ShaXam.DependencyServices
{
    public interface IStatusBarStyleManager
    {
        void SetColoredStatusBar(string hexColor);
        void SetWhiteStatusBar();
    }
}
