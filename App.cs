namespace AddinTest
{
    using System;
    using System.Reflection;
    using Autodesk.Revit.DB.Events;
    using Autodesk.Revit.UI;
    using Microsoft.AspNetCore.SignalR.Client;

    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            a.ControlledApplication.DocumentOpened += ControlledApplicationOnDocumentOpened;
            return Result.Succeeded;
        }

        private void ControlledApplicationOnDocumentOpened(object sender, DocumentOpenedEventArgs e)
        {
            var assembly2 = Assembly.Load("Microsoft.Extensions.Logging.Abstractions, Version=6.0.0.3, Culture=neutral, PublicKeyToken=adb9793829ddae60");
            var b = new HubConnectionBuilder();
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
