﻿// Copyright © 2010-2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace CefSharp
{
    // Should rightfully live in the CefSharp.WinForms project, but the problem is that it's being used from CefSharp.Core
    // so the dependency would go the wrong way... Has to be here for the time being.
    public interface IWinFormsWebBrowser : IWebBrowser
    {
        IMenuHandler MenuHandler { get; set; }

        void OnGotFocus();
        bool OnSetFocus(CefFocusSource source);
        void OnTakeFocus(bool next);
    }
}
