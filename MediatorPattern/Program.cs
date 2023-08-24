using MediatorPattern;

class Program
{
    static void Main(string[] args)
    {
        // Create a message mediator for communication
        IMessageMediator messageMediator = new MessageMediator();

        // Create users and register them with the mediator
        IUser homer = new User("Homer", messageMediator);
        IUser marge = new User("Marge", messageMediator);
        IUser bart = new User("Bart", messageMediator);
        IUser lisa = new User("Lisa", messageMediator);

        // Simulate message exchanges
        homer.SendMessage("D'oh!");  // Homer broadcasts a message
        marge.SendMessage("Homer, stop!"); // Marge sends a private message to Homer
        bart.SendMessage("Eat my shorts!"); // Bart broadcasts a message
        lisa.SendMessage("Time for saxophone practice!"); // Lisa broadcasts a message

        Console.WriteLine();

        homer.SendMessage("What's for dinner?"); // Homer broadcasts a message
        marge.SendMessage("I'll make spaghetti."); // Marge broadcasts a message
        bart.SendMessage("Boring!"); // Bart broadcasts a message
        lisa.SendMessage("I have a school project."); // Lisa broadcasts a message

        Console.WriteLine();

        bart.SendMessage("Hey Lisa, wanna team up on that project?"); // Bart sends a private message to Lisa
        lisa.SendMessage("Sure, Bart. Let's do it!"); // Lisa replies to Bart's private message
    }
}