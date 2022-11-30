﻿namespace FellowOakDicom.Network
{
    /// <summary>
    /// Contains the necessary parameters to start a new network listener
    /// </summary>
    public class NetworkListenerCreationOptions
    {
        /// <summary>
        /// IP address(es) to listen to
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Network port to listen on
        /// </summary>
        public int Port { get; set; }
    }
}