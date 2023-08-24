namespace MediatorPattern
{
    // Colleague/User interface
    /// <summary>
    /// Represents a user in the messaging system.
    /// </summary>
    interface IUser
    {
        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Sends a message to a user or broadcasts to all users.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="receiver">The intended receiver (optional, for private messages).</param>
        void SendMessage(string message, IUser receiver = null);

        /// <summary>
        /// Receives a message from another user.
        /// </summary>
        /// <param name="message">The received message.</param>
        /// <param name="sender">The sender of the message.</param>
        void ReceiveMessage(string message, IUser sender);
    }
}
