using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Commands;
using Invert.Core.GraphDesigner.Unity.WindowsPlugin;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem.ViewModels
{
    public class LoginScreenViewModel : WindowViewModel
    {

        public string Username { get; set; }
        public string Password { get; set; }

    

        public void Login()
        {
            InvertApplication.ExecuteInBackground(new LoginCommand()
            {
                Password = Password,
                Username = Username
            });
        }

    }
}
