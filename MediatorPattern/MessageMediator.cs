namespace MediatorPattern
{
    // Concrete Mediator
    /// <summary>
    /// Concrete implementation of the message mediator.
    /// Manages communication between users.
    /// </summary>
    class MessageMediator : IMessageMediator
    {
        private List<IUser> users = new List<IUser>();

        /// <summary>
        /// Registers a user with the mediator.
        /// </summary>
        /// <param name="user">The user to register.</param>
        public void RegisterUser(IUser user)
        {
            users.Add(user);
        }

        /// <summary>
        /// Sends a message to a user or broadcasts to all users.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The sender of the message.</param>
        /// <param name="receiver">The intended receiver (optional, for private messages).</param>
        public void SendMessage(string message, IUser sender, IUser receiver = null)
        {
            if (receiver != null)
            {
                // Send a private message to the specified receiver.
                receiver.ReceiveMessage(message, sender);
            }
            else
            {
                // Broadcast the message to all users except the sender.
                foreach (var user in users)
                {
                    if (user != sender)
                        user.ReceiveMessage(message, sender);
                }
            }
        }
    }
}