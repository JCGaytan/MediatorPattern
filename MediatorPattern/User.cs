namespace MediatorPattern
{
    // Concrete User
    /// <summary>
    /// Represents a concrete user in the messaging system.
    /// </summary>
    class User : IUser
    {
        public string Name { get; private set; }
        private IMessageMediator messageMediator;

        /// <summary>
        /// Creates a new user with the given name and registers them with the mediator.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        /// <param name="messageMediator">The mediator for sending messages.</param>
        public User(string name, IMessageMediator messageMediator)
        {
            Name = name;
            this.messageMediator = messageMediator;
            messageMediator.RegisterUser(this);
        }

        /// <summary>
        /// Sends a message to a user or broadcasts to all users.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="receiver">The intended receiver (optional, for private messages).</param>
        public void SendMessage(string message, IUser receiver = null)
        {
            // Use the mediator to send the message.
            messageMediator.SendMessage(message, this, receiver);
        }

        /// <summary>
        /// Receives a message from another user.
        /// </summary>
        /// <param name="message">The received message.</param>
        /// <param name="sender">The sender of the message.</param>
        public void ReceiveMessage(string message, IUser sender)
        {
            Console.WriteLine($"[{Name}] received from [{sender.Name}]: {message}");
        }
    }
}