# 🦄 DOTNET TEMPLATE SKELETON BASED ON ONION ARCHITECTURE

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## TABLA DE CONTENIDO

* 🔥 [Description](#description)
* ⚙️ [Install](#install)
* 📓 [Summary](#summary)
* 📄 [License](#license)
* ⭐️ [Give me a star](#give-me-a-star)

## DESCRIPTION

This project is a DOTNET template skeleton based on onion architecture.

## INSTALL

Clone this repository

```bash
gh repo clone FernandoCalmet/dotnet-onion-architecture-skeleton
```

## SUMMARY

### Simplifying Software Development
As a software developer, you're probably aware that designing a robust, scalable, and maintainable software architecture is not an easy task. That's where Onion Architecture comes in as an approach to software development that helps overcome these challenges. In this article, we'll dive deeper into Onion Architecture, its benefits, and how to implement it in Dotnet.

### Understanding Onion Architecture
Onion Architecture is a software design pattern developed by Jeffrey Palermo. It is adopted from Uncle Bob's Clean Architecture, and the idea behind the concept is to make software independent of frameworks, databases, UI, and other external dependencies. Simply put, it helps to decouple the application into different layers, with each layer representing a specific concern or responsibility. The Onion Architecture comprises four layers: 

### Domain Layer
The Domain layer is the heart of the Onion Architecture. It defines the core business logic of the application and contains entities, value objects, business rules, and interfaces that define contracts with other layers.

### Application Layer
The Application layer works as an interface between the Presentation and the Domain layer. It contains application services, which orchestrate the application flow and maps the data between the Domain and Presentation layer.

### Infrastructure Layer
The Infrastructure layer contains all the technical details of the application, like data storage, logging, messaging, and so on. It also implements the interfaces defined in the Domain layer.

### Presentation Layer
The Presentation layer is responsible for presenting the application output to the users, like web pages, APIs, and user interfaces. It communicates with the Application layer to get the information from the Domain layer.

### Benefits of Onion Architecture in Dotnet
Onion Architecture provides several benefits, like testability, maintainability, and flexibility. With Onion Architecture, you can write unit tests that only depend on the Domain layer and are not affected by any framework or external dependencies. It makes it easier to switch the UI or the database layer without affecting the core business logic. Moreover, the architecture follows the Single Responsibility Principle, making the code easier to maintain and refactor.

### Structure

Here's an example of how the directory structure might look:

```
Solution/
├── Core/
│   ├── Entities/
│   ├── Interfaces/
│   ├── Services/
│   └── ...
├── Application/
│   ├── UseCases/
│   ├── Services/
│   ├── Interfaces/
│   └── ...
├── Infrastructure/
│   ├── Repositories/
│   ├── Data/
│   └── ...
├── Presentation/
│   ├── Controllers/
│   ├── Views/
│   ├── Models/
│   └── ...
└── ...
```

In this example, the Core project contains the domain entities and business logic, the Application project contains the use cases and services, the Infrastructure project contains the data access layer, and the Presentation project contains the user interface components. Note that this is just one example of how to implement Onion Architecture in .NET, and you may need to adapt it to your specific needs and preferences.

### Conclusion
In conclusion, Onion Architecture is an excellent software design pattern that can help you build robust and maintainable applications. By separating the application into different layers, it promotes decoupling and testability. We hope that this article has given you a good understanding of Onion Architecture and its implementation in Dotnet. Next time you start a new project, give Onion Architecture a try, and see the difference yourself!

## LICENSE
This project is licensed under the License (MIT License) - see the [LICENSE](LICENSE) file for details.

## GIVE ME A STAR
If you found this Implementation useful or used it in your Projects, please give it a star. Thank you! Or, if you're feeling really generous, [Support the project with a small contribution!](https://ko-fi.com/fernandocalmet).

<!--- reference style links --->
[github-shield]: https://img.shields.io/badge/-@fernandocalmet-%23181717?style=flat-square&logo=github
[github-url]: https://github.com/fernandocalmet
[kofi-shield]: https://img.shields.io/badge/-@fernandocalmet-%231DA1F2?style=flat-square&logo=kofi&logoColor=ff5f5f
[kofi-url]: https://ko-fi.com/fernandocalmet
[linkedin-shield]: https://img.shields.io/badge/-fernandocalmet-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fernandocalmet
[linkedin-url]: https://www.linkedin.com/in/fernandocalmet
[khanakat-shield]: https://img.shields.io/badge/khanakat.com-brightgreen?style=flat-square
[khanakat-url]: https://khanakat.com
