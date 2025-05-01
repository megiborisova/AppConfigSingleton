# AppConfigSingleton – Project Demonstrating the Singleton Pattern in C#

## Description

This project demonstrates the implementation of the **Singleton** design pattern in C#. It features a class named `AppConfig` that centralizes access to application settings (language, debug mode, log file path) through a single shared instance.

## Applied OOP Concepts

| Topic                         | How it is applied                             |
|-------------------------------|-----------------------------------------------|
| Classes and Objects           | Classes `AppConfig` and `Program`             |
| Encapsulation                 | Fields and properties using `private` and `public` |
| Static Fields and Methods     | `Instance`, `DefaultLanguage`, `PrintDefaultLanguage()` |
| Constructors                  | Private constructor (singleton pattern)       |
| Properties (get/set)          | `Language`, `IsDebugMode`, `LogFilePath`      |
| Nested Class                  | Class `Info` defined inside `AppConfig`       |
| Singleton Pattern             | Implemented via `AppConfig.Instance`          |