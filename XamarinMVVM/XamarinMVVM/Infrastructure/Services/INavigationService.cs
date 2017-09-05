using System;

using Xamarin.Forms;

using XamarinMVVM.Enums;

namespace XamarinMVVM.Infrastructure.Services
{
    public interface INavigationService
    {
        void GoBack();
        void NavigateTo(AppViews pageKey);
        void NavigateTo(AppViews pageKey, object parameter);

        void Configure ( AppViews pageKey, Type pageType );

        void Initialize ( NavigationPage navigation );
    }
}
