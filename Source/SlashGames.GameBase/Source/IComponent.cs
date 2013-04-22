﻿// -----------------------------------------------------------------------
// <copyright file="IComponent.cs" company="Slash Games">
// Copyright (c) Slash Games. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace SlashGames.GameBase
{
    using SlashGames.Collections.AttributeTables;

    /// <summary>
    /// Contract that all game components have to fulfill if they are to be
    /// attached to entities.
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Initializes this component with the data stored in the passed
        /// attribute table.
        /// </summary>
        /// <param name="attributeTable">Component data.</param>
        void InitComponent(IAttributeTable attributeTable);
    }
}