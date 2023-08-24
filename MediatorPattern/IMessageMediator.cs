namespace MediatorPattern
{
    /// <summary>
    /// Defines the communication contract for sending messages between users.
    /// </summary>
    interface IMessageMediator
    {
        /// <summary>
        /// Sends a message to a user or broadcasts to all users.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The sender of the message.</param>
        /// <param name="receiver">The intended receiver (optional, for private messages).</param>
        void SendMessage(string message, IUser sender, IUser receiver = null);

        /// <summary>
        /// Registers a user with the mediator.
        /// </summary>
        /// <param name="user">The user to register.</param>
        void RegisterUser(IUser user);
    }
}
