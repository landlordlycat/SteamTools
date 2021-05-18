using Newtonsoft.Json.Linq;
using ReactiveUI;
using System.Application.Models;
using System.Application.UI.Resx;
using System.Properties;

namespace System.Application.UI.ViewModels
{
    public class ExportAuthWindowViewModel : WindowViewModel
    {
        public ExportAuthWindowViewModel() : base()
        {
            Title = ThisAssembly.AssemblyTrademark + " | " + AppResources.LocalAuth_ProtectionAuth;
        }

        private bool _IsEncryption;
        public bool IsEncryption
        {
            get => _IsEncryption;
            set => this.RaiseAndSetIfChanged(ref _IsEncryption, value);
        }

        public void ExportAuth() 
        {

        }
    }
}