// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="HostType.cs" company="StealFocus">
//   Copyright StealFocus. All rights reserved.
// </copyright>
// <summary>
//   Defines the HostType type.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------
namespace StealFocus.BizTalkExtensions
{
    /// <summary>
    /// Host types.
    /// </summary>
    public enum HostType
    {
        /// <summary>
        /// Invalid host type.
        /// </summary>
        Invalid,

        /// <summary>
        /// In-process host.
        /// </summary>
        InProcess,

        /// <summary>
        /// Isolated host, for example IIS.
        /// </summary>
        Isolated
    }
}