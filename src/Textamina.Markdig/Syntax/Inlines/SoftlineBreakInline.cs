// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
namespace Textamina.Markdig.Syntax.Inlines
{
    public class SoftlineBreakInline : LeafInline
    {
        public override string ToString()
        {
            return "\\n";
        }
    }
}