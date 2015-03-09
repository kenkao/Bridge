﻿using System;
using Bridge.Foundation;

namespace Bridge.Html5
{
    /// <summary>
    /// The HTMLEmbedElement interface, which provides special properties (beyond the regular <htmlelement> interface it also has available to it by inheritance) for manipulating <embed> elements.
    /// </summary>
    [Ignore]
    [Name("HTMLEmbedElement")]
    public class EmbedElement : Element
    {
        [Template("document.createElement('embed')")]
        public EmbedElement()
        {
        }

        /// <summary>
        /// Reflects the height HTML attribute, containing the displayed height of the resource.
        /// </summary>
        public int Height;

        /// <summary>
        /// The name of the embedded object.
        /// </summary>
        public string Name;

        /// <summary>
        /// Reflects the src HTML attribute, containing the address of the resource.
        /// </summary>
        public string Src;

        /// <summary>
        /// Reflects the type HTML attribute, containing the type of the resource.
        /// </summary>
        public string Type;

        /// <summary>
        /// Reflects the width HTML attribute, containing the displayed width of the resource.
        /// </summary>
        public string Width;
    }
}