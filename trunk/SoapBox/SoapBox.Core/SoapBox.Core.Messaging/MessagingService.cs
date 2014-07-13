#region "SoapBox.Core License"
/// <header module="SoapBox.Core"> 
/// Copyright (C) 2009 SoapBox Automation, All Rights Reserved.
/// Contact: SoapBox Automation Licencing (license@soapboxautomation.com)
/// 
/// This file is part of SoapBox Core.
/// 
/// Commercial Usage
/// Licensees holding valid SoapBox Automation Commercial licenses may use  
/// this file in accordance with the SoapBox Automation Commercial License
/// Agreement provided with the Software or, alternatively, in accordance 
/// with the terms contained in a written agreement between you and
/// SoapBox Automation Inc.
/// 
/// GNU Lesser General Public License Usage
/// SoapBox Core is free software: you can redistribute it and/or modify 
/// it under the terms of the GNU Lesser General Public License
/// as published by the Free Software Foundation, either version 3 of the
/// License, or (at your option) any later version.
/// 
/// SoapBox Core is distributed in the hope that it will be useful, 
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Lesser General Public License for more details.
/// 
/// You should have received a copy of the GNU Lesser General Public License 
/// along with SoapBox Core. If not, see <http://www.gnu.org/licenses/>.
/// </header>
#endregion
        
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace SoapBox.Core.Messaging
{
    [Export(Services.Messaging.MessagingService, typeof(IMessagingService))]
    class MessagingService : IMessagingService
    {
        [Import(Services.Logging.LoggingService, typeof(ILoggingService))]
        private Lazy<ILoggingService> loggingService { get; set; }

        #region IMessagingService Members

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(
                message, title);
            loggingService.Value.Info(message);
        }

        public DialogResult ShowDialog(string message, string title, MessageBoxButtons buttons)
        {
            DialogResult result = MessageBox.Show(
                message, title, buttons);
            loggingService.Value.Info(message + "; result = " + result.ToString());
            return result;
        }

        #endregion
    }
}