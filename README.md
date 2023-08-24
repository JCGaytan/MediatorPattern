# Mediator Pattern Example

This repository contains a simple example of the Mediator design pattern implemented in C#. The Mediator pattern is a behavioral design pattern that promotes loose coupling between objects by centralizing communication and interaction logic.

## Mediator Pattern

The **Mediator Pattern** is a behavioral design pattern that defines an object (the mediator) which encapsulates how a set of objects interact. It promotes a *many-to-many* relationship between objects, reducing dependencies and making the communication more manageable.

### How It Works

In the Mediator pattern, multiple objects (colleagues) communicate with each other through a mediator object. Instead of having direct references to each other, objects communicate indirectly through the mediator, which facilitates the interaction. This approach improves the maintainability and extensibility of the codebase.

### Benefits

The Mediator pattern offers several benefits in software development:

1. **Reduced Coupling**: Objects don't need to know about each other explicitly, reducing tight coupling. This makes it easier to add, modify, or remove objects without affecting the entire system.

2. **Centralized Logic**: Communication logic is centralized in the mediator. This simplifies the understanding of communication flows and makes changes easier to manage.

3. **Reusability**: The mediator encapsulates communication rules, promoting reuse across different parts of the system.

4. **Scalability**: Adding new colleagues doesn't require modifying existing colleagues. The mediator handles the interactions between them.

5. **Promotes Maintainability**: With communication logic in one place, debugging and maintenance become more straightforward.

## Example Usage

In this repository, you'll find a simple implementation of the Mediator pattern using C#. The example consists of users in a messaging system.

### `IMessageMediator` Interface

The `IMessageMediator` interface defines the communication contract for sending messages between users.

#### Methods

- `void SendMessage(string message, IUser sender, IUser receiver = null)`: Sends a message to a user or broadcasts to all users.
- `void RegisterUser(IUser user)`: Registers a user with the mediator.

### `MessageMediator` Class

The `MessageMediator` class is a concrete implementation of the `IMessageMediator` interface. It manages communication between users.

#### Constructors

- `MessageMediator()`: Initializes a new instance of the `MessageMediator` class.

#### Methods

- `void SendMessage(string message, IUser sender, IUser receiver = null)`: Sends a message to a user or broadcasts to all users.
- `void RegisterUser(IUser user)`: Registers a user with the mediator.

### `User` Class

The `User` class represents individual users in the messaging system.

#### Constructors

- `User(string name, IMessageMediator messageMediator)`: Creates a new user with the given name and registers them with the mediator.

#### Properties

- `string Name { get; private set; }`: Gets the name of the user.

#### Methods

- `void SendMessage(string message, IUser receiver = null)`: Sends a message to a user or broadcasts to all users.
- `void ReceiveMessage(string message, IUser sender)`: Receives a message from another user.

## How to Run

To see the Mediator pattern in action, follow these steps:

1. Clone this repository: `git clone https://github.com/JCGaytan/MediatorPattern.git`
2. Open the solution in your preferred C# development environment.
3. Build and run the program to observe the interaction between users through the mediator.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.

## Conclusion

The Mediator pattern is a powerful tool in software development, enabling cleaner code, better separation of concerns, and easier maintenance. By centralizing communication logic, it provides a scalable and maintainable approach to handling interactions between objects. This example repository serves as a starting point for understanding and implementing the Mediator pattern in your projects.

Feel free to contribute, provide feedback, or extend the example further. Happy coding!

---

# Español

# Ejemplo de Patrón Mediador

Este repositorio contiene un ejemplo simple del patrón de diseño Mediator implementado en C#. El patrón Mediador es un patrón de diseño conductual que promueve el acoplamiento flojo entre objetos al centralizar la lógica de comunicación e interacción.

## Patrón Mediador

El **Patrón Mediador** es un patrón de diseño conductual que define un objeto (el mediador) que encapsula cómo interactúa un conjunto de objetos. Promueve una relación *muchos a muchos* entre objetos, reduciendo dependencias y facilitando la comunicación.

### Cómo Funciona

En el patrón Mediador, varios objetos (colegas) se comunican entre sí a través de un objeto mediador. En lugar de tener referencias directas entre sí, los objetos se comunican indirectamente a través del mediador, lo que facilita la interacción. Este enfoque mejora la mantenibilidad y la capacidad de extensión de la base de código.

### Beneficios

El patrón Mediador ofrece varios beneficios en el desarrollo de software:

1. **Acoplamiento Reducido**: Los objetos no necesitan conocerse explícitamente, lo que reduce el acoplamiento. Esto facilita agregar, modificar o eliminar objetos sin afectar todo el sistema.

2. **Lógica Centralizada**: La lógica de comunicación se centraliza en el mediador. Esto simplifica la comprensión de los flujos de comunicación y facilita la gestión de cambios.

3. **Reutilización**: El mediador encapsula las reglas de comunicación, fomentando la reutilización en diferentes partes del sistema.

4. **Escalabilidad**: Agregar nuevos colegas no requiere modificar los colegas existentes. El mediador maneja las interacciones entre ellos.

5. **Promueve la Mantenibilidad**: Al centralizar la lógica de comunicación, la depuración y el mantenimiento se vuelven más sencillos.

## Uso de Ejemplo

En este repositorio, encontrarás una implementación simple del patrón Mediador usando C#. El ejemplo consiste en usuarios en un sistema de mensajería.

### Interfaz `IMessageMediator`

La interfaz `IMessageMediator` define el contrato de comunicación para enviar mensajes entre usuarios.

#### Métodos

- `void SendMessage(string message, IUser sender, IUser receiver = null)`: Envía un mensaje a un usuario o lo difunde a todos los usuarios.
- `void RegisterUser(IUser user)`: Registra un usuario en el mediador.

### Clase `MessageMediator`

La clase `MessageMediator` es una implementación concreta de la interfaz `IMessageMediator`. Gestiona la comunicación entre usuarios.

#### Constructores

- `MessageMediator()`: Inicializa una nueva instancia de la clase `MessageMediator`.

#### Métodos

- `void SendMessage(string message, IUser sender, IUser receiver = null)`: Envía un mensaje a un usuario o lo difunde a todos los usuarios.
- `void RegisterUser(IUser user)`: Registra un usuario en el mediador.

### Clase `User`

La clase `User` representa usuarios individuales en el sistema de mensajería.

#### Constructores

- `User(string name, IMessageMediator messageMediator)`: Crea un nuevo usuario con el nombre dado y lo registra en el mediador.

#### Propiedades

- `string Name { get; private set; }`: Obtiene el nombre del usuario.

#### Métodos

- `void SendMessage(string message, IUser receiver = null)`: Envía un mensaje a un usuario o lo difunde a todos los usuarios.
- `void ReceiveMessage(string message, IUser sender)`: Recibe un mensaje de otro usuario.

## Cómo Ejecutar

Para ver el patrón Mediador en acción, sigue estos pasos:

1. Clona este repositorio: `git clone https://github.com/JCGaytan/MediatorPattern.git`
2. Abre la solución en tu entorno de desarrollo C# preferido.
3. Compila y ejecuta el programa para observar la interacción entre usuarios a través del mediador.

## Licencia

Este proyecto está bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE.txt) para más detalles.

## Conclusión

El patrón Mediador es una herramienta poderosa en el desarrollo de software que permite un código más limpio, una mejor separación de responsabilidades y un mantenimiento más sencillo. Al centralizar la lógica de comunicación, proporciona un enfoque escalable y mantenible para manejar las interacciones entre objetos. Este repositorio de ejemplo sirve como punto de partida para comprender e implementar el patrón Mediador en tus proyectos.

Siéntete libre de contribuir, dar feedback o extender el ejemplo aún más. ¡Feliz codificación!

---

# Français

# Exemple de Modèle Médiateur

Ce référentiel contient un exemple simple du modèle de conception Médiateur implémenté en C#. Le modèle Médiateur est un modèle de conception comportemental qui favorise le couplage lâche entre les objets en centralisant la logique de communication et d'interaction.

## Modèle Médiateur

Le **Modèle Médiateur** est un modèle de conception comportemental qui définit un objet (le médiateur) qui encapsule la manière dont un ensemble d'objets interagit. Il favorise une relation *plusieurs à plusieurs* entre les objets, réduisant les dépendances et rendant la communication plus gérable.

### Comment Ça Fonctionne

Dans le modèle Médiateur, plusieurs objets (collègues) communiquent les uns avec les autres via un objet médiateur. Au lieu d'avoir des références directes les uns aux autres, les objets communiquent indirectement via le médiateur, ce qui facilite l'interaction. Cette approche améliore la maintenabilité et l'extensibilité de la base de code.

### Avantages

Le modèle Médiateur offre plusieurs avantages dans le développement logiciel :

1. **Couplage Réduit** : Les objets n'ont pas besoin de se connaître explicitement, ce qui réduit le couplage. Cela facilite l'ajout, la modification ou la suppression d'objets sans affecter l'ensemble du système.

2. **Logique Centralisée** : La logique de communication est centralisée dans le médiateur. Cela simplifie la compréhension des flux de communication et facilite la gestion des modifications.

3. **Réutilisabilité** : Le médiateur encapsule les règles de communication, favorisant la réutilisation dans différentes parties du système.

4. **Évolutivité** : Ajouter de nouveaux collègues ne nécessite pas de modifier les collègues existants. Le médiateur gère les interactions entre eux.

5. **Favorise la Maintenabilité** : En centralisant la logique de communication, le débogage et la maintenance deviennent plus simples.

## Utilisation de l'Exemple

Dans ce référentiel, vous trouverez une mise en œuvre simple du modèle Médiateur en utilisant C#. L'exemple consiste en des utilisateurs dans un système de messagerie.

### Interface `IMessageMediator`

L'interface `IMessageMediator` définit le contrat de communication pour l'envoi de messages entre les utilisateurs.

#### Méthodes

- `void SendMessage(string message, IUser sender, IUser receiver = null)`: Envoie un message à un utilisateur ou diffuse à tous les utilisateurs.
- `void RegisterUser(IUser user)`: Enregistre un utilisateur auprès du médiateur.

### Classe `MessageMediator`

La classe `MessageMediator` est une implémentation concrète de l'interface `IMessageMediator`. Elle gère la communication entre les utilisateurs.

#### Constructeurs

- `MessageMediator()`: Initialise une nouvelle instance de la classe `MessageMediator`.

#### Méthodes

- `void SendMessage(string message, IUser sender, IUser receiver = null)`: Envoie un message à un utilisateur ou diffuse à tous les utilisateurs.
- `void RegisterUser(IUser user)`: Enregistre un utilisateur auprès du médiateur.

### Classe `User`

La classe `User` représente des utilisateurs individuels dans le système de messagerie.

#### Constructeurs

- `User(string name, IMessageMediator messageMediator)`: Crée un nouvel utilisateur avec le nom donné et l'enregistre auprès du médiateur.

#### Propriétés

- `string Name { get; private set; }`: Obtient le nom de l'utilisateur.

#### Méthodes

- `void SendMessage(string message, IUser receiver = null)`: Envoie un message à un utilisateur ou diffuse à tous les utilisateurs.
- `void ReceiveMessage(string message, IUser sender)`: Reçoit un message d'un autre utilisateur.

## Comment Exécuter

Pour voir le modèle Médiateur en action, suivez ces étapes :

1. Clonez ce référentiel : `git clone https://github.com/JCGaytan/MediatorPattern.git`
2. Ouvrez la solution dans votre environnement de développement C# préféré.
3. Compilez et exécutez le programme pour observer l'interaction entre les utilisateurs via le médiateur.

## Licence

Ce projet est sous licence MIT - consultez le fichier [LICENSE](LICENSE) pour plus de détails.

## Conclusion

Le modèle Médiateur est un outil puissant dans le développement logiciel, permettant un code plus propre, une meilleure séparation des responsabilités et une maintenance plus aisée. En centralisant la logique de communication, il offre une approche évolutive et maintenable pour gérer les interactions entre les objets. Ce référentiel d'exemple sert de point de départ pour comprendre et mettre en œuvre le modèle Médiateur dans vos projets.

N'hésitez pas à contribuer, à fournir des commentaires ou à étendre davantage l'exemple. Bon codage !
