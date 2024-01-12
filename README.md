# 🦄 DOTNET TEMPLATE SKELETON BASED ON ONION ARCHITECTURE

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## CONTENT

* 🔥 [Description](#description)
* ⚙️ [Install](#install)
* 📓 [Summary](#summary)
* 🏗️ [Project Structure](#project-structure)
* 📄 [License](#license)
* ⭐️ [Give me a star](#give-me-a-star)

## DESCRIPTION

This project is a .NET template skeleton built on the Onion Architecture, providing a solid foundation for scalable, maintainable, and robust application development.

## INSTALL

Clone this repository using:

```bash
gh repo clone FernandoCalmet/dotnet-onion-architecture-skeleton
```

## SUMMARY

### Simplifying Software Development
Developing a robust, scalable, and maintainable software architecture is a complex task. The Onion Architecture, a design pattern developed by Jeffrey Palermo and inspired by Uncle Bob's Clean Architecture, addresses these challenges. This architecture aims to make software independent of external dependencies like frameworks, databases, and UI, promoting decoupling and testability.

### Understanding Onion Architecture
The Onion Architecture is structured in four key layers:

### Domain Layer
The core of the architecture, containing business logic, entities, value objects, business rules, and interfaces for contracts with other layers.

### Application Layer
Serves as an interface between the Presentation and Domain layers, containing services that orchestrate application flow and data mapping.

### Infrastructure Layer
Houses technical details like data storage, logging, messaging, etc., and implements interfaces from the Domain layer.

### Presentation Layer
Responsible for presenting output to users and communicating with the Application layer to access Domain layer information.

### Benefits of Onion Architecture in Dotnet
The Onion Architecture enhances testability, maintainability, and flexibility. It allows writing unit tests that depend solely on the Domain layer, unaffected by external frameworks or dependencies. This design also follows the Single Responsibility Principle, simplifying maintenance and refactoring.

## Project Structure
The updated project structure aligns with the principles of Onion Architecture, ensuring a clear separation of concerns and improved maintainability. Here's an overview of the updated directory structure:

```
MyCompany.MyProduct.sln
│
├───src
│   ├───Solution Items
│   │   ├───.editorconfig
│   │   ├───DirectoryBuild.props
│   │   └───Directory.Packages.props
│   ├───Core
│   │   ├───MyCompany.MyProduct.Application
│   │   │   ├───Abstractions
│   │   │   │   ├───Authentication
│   │   │   │   ├───Authorization
│   │   │   │   ├───Common
│   │   │   │   ├───Data
│   │   │   │   ├───Emails
│   │   │   │   ├───Messaging
│   │   │   │   └───Notifications
│   │   │   ├───Behaviors
│   │   │   ├───Exceptions
│   │   │   ├───Extensions
│   │   │   └───Features
│   │   └───MyCompany.MyProduct.Domain
│   │       ├───Entities
│   │       ├───Enums
│   │       ├───Errors
│   │       ├───Events
│   │       ├───Exceptions
│   │       ├───Primitives
│   │       ├───Repositories
│   │       ├───Services
│   │       ├───Shared
│   │       ├───Specifications
│   │       └───ValueObjects
│   └───External
│       ├───MyCompany.MyProduct.Api
│       │   ├───Extensions
│       │   └───Dockerfile
│       ├───MyCompany.MyProduct.Infrastructure
│       │   ├───Authentication
│       │   ├───Authorization
│       │   ├───BackgroundJobs
│       │   ├───Common
│       │   ├───Emails
│       │   ├───Messaging
│       │   └───Notifications
│       ├───MyCompany.MyProduct.Persistence
│       │   ├───Configurations
│       │   ├───Constants
│       │   ├───Extensions
│       │   ├───Migrations
│       │   └───Repositories
│       └───MyCompany.MyProduct.Presentation
│           ├───Contracts
│           ├───Endpoints
│           └───Routes
├───tests
│   └───Core
│       ├───MyCompany.MyProduct.Application.UnitTests
│       │   ├───Data
│       │   └───Features
│       ├───MyCompany.MyProduct.ArchitectureTests
│       │   ├───Application
│       │   └───Domain
│       └───MyCompany.MyProduct.Domain.UnitTests
│           ├───Data
│           └───Features
└───docker-compose
```

This structure ensures that each component of our system is neatly organized, facilitating easier navigation and understanding of the codebase.

### Conclusion
Onion Architecture offers a robust framework for building maintainable and scalable applications in .NET. By segregating the application into distinct layers, it promotes a clean separation of concerns and enhances the overall software quality. We encourage you to adopt this architecture in your next .NET project for a noticeable improvement in your development process.

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
