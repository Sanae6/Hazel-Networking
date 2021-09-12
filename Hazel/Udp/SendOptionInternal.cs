using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hazel.Udp
{
    /// <summary>
    ///     Control states for SendOption enumeration when using UDP.
    /// </summary>
    public enum UdpSendOption : byte
    {
        /// <summary>
        ///     Bit used to reliably deliver a message
        /// </summary>
        Reliable = 1,
        /// <summary>
        ///     Bit used to order a message
        /// </summary>
        Ordered = 2,
        /// <summary>
        ///     Bit used to fragment a message   
        /// </summary>
        Fragment = 4,
        /// <summary>
        ///     Sugar used to declare a non-control packet
        /// </summary>
        Data = 7,
        /// <summary>
        ///     Bit used to declare a control packet
        /// </summary>
        Control = 8,

        /// <summary>
        ///     Control packet for initiating communication.
        /// </summary>
        Hello = 8,

        /// <summary>
        ///     Control packet to keep a connection alive.
        /// </summary>
        Ping = 12,

        /// <summary>
        ///     Control packet to end communication.
        /// </summary>
        Disconnect = 9,

        /// <summary>
        ///     Control packet acknowledging the receipt of a message.
        /// </summary>
        Acknowledgement = 10,
    }
}
