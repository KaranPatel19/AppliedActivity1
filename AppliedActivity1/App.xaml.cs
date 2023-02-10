﻿using AppliedActivity1.Services;
namespace AppliedActivity1;

public partial class App : Application
{
    const int WindowWidth = 360;
    const int WindowHeight = 680;

    public App()
    {
        InitializeComponent();

        DependencyService.Register<GOTDataStore>();
        DependencyService.Register<WebClientService>();

        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
            #if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
            #endif
        });


        MainPage = new AppShell();
    }
}

