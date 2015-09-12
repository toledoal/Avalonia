﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

namespace Perspex.Layout
{
    /// <summary>
    /// Provides helper methods needed for layout.
    /// </summary>
    public static class LayoutHelper
    {
        /// <summary>
        /// Calculates a control's size based on its <see cref="ILayoutable.Width"/>,
        /// <see cref="ILayoutable.Height"/>, <see cref="ILayoutable.MinWidth"/>,
        /// <see cref="ILayoutable.MaxWidth"/>, <see cref="ILayoutable.MinHeight"/> and
        /// <see cref="ILayoutable.MaxHeight"/>.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="constraints">The space available for the control.</param>
        /// <returns>The control's size.</returns>
        public static Size ApplyLayoutConstraints(ILayoutable control, Size constraints)
        {
            double width = (control.Width > 0) ? control.Width : constraints.Width;
            double height = (control.Height > 0) ? control.Height : constraints.Height;
            width = Math.Min(width, control.MaxWidth);
            width = Math.Max(width, control.MinWidth);
            height = Math.Min(height, control.MaxHeight);
            height = Math.Max(height, control.MinHeight);
            return new Size(width, height);
        }
    }
}