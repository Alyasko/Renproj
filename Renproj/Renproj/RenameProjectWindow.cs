﻿using Renproj.Core;

namespace Renproj
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("eed7595c-50db-48e9-8a0d-b8b5fe1fc591")]
    public class RenameProjectWindow : ToolWindowPane
    {
        private readonly Rp _rp;

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameProjectWindow"/> class.
        /// </summary>
        public RenameProjectWindow() : base(null)
        {
            this.Caption = "Renproj - Rename Project";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new RenameProjectWindowControl();
        }
    }
}
