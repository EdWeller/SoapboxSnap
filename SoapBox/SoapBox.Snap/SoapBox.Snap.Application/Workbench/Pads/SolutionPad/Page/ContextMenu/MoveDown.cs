#region "SoapBox.Snap License"
/// <header module="SoapBox.Snap"> 
/// Copyright (C) 2009-2015 SoapBox Automation, All Rights Reserved.
/// Contact: SoapBox Automation Licencing (license@soapboxautomation.com)
/// 
/// This file is part of SoapBox Snap.
/// 
/// SoapBox Snap is free software: you can redistribute it and/or modify it
/// under the terms of the GNU General Public License as published by the 
/// Free Software Foundation, either version 3 of the License, or 
/// (at your option) any later version.
/// 
/// SoapBox Snap is distributed in the hope that it will be useful, but 
/// WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.
/// 
/// You should have received a copy of the GNU General Public License along
/// with SoapBox Snap. If not, see <http://www.gnu.org/licenses/>.
/// </header>
#endregion
        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoapBox.Core;
using System.ComponentModel.Composition;

namespace SoapBox.Snap.Application.Workbench.Pads.SolutionPad.PageItem.ContextMenu
{
    [Export(ExtensionPoints.Workbench.Pads.SolutionPad.PageItem.ContextMenu, typeof(IMenuItem))]
    class MoveDown : AbstractMenuItem
    {
        public MoveDown()
        {
            ID = Extensions.Workbench.Pads.SolutionPad_.PageItem.ContextMenu.MoveDown;
            InsertRelativeToID = Extensions.Workbench.Pads.SolutionPad_.PageItem.ContextMenu.MoveUp;
            BeforeOrAfter = RelativeDirection.After;
            Header = Resources.Strings.Solution_Pad_PageItem_MoveDown;
            ToolTip = Resources.Strings.Solution_Pad_PageItem_MoveDown_ToolTip;
            SetIconFromBitmap(Resources.Images.Page_MoveDown);
        }

        protected override void Run()
        {
            base.Run();
            var page = Context as SoapBox.Snap.Application.PageItem;
            if (page != null)
            {
                page.MoveDown();
            }
        }
    }
}
