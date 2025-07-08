# 🚀 Proxy Pattern - Minimal .NET API

This is a simple ASP.NET Core Minimal Web API that demonstrates the Proxy Design Pattern. 
The Proxy Pattern provides a way to control access, add caching, or defer expensive operations without modifying the actual service implementation.


## 🔍 Real-World Analogy
Imagine a gatekeeper in front of a vault.

You don’t let just anyone walk in.

The gatekeeper checks credentials (access control), ensures no duplicate requests (caching), or logs visits.

The proxy is that gatekeeper. It stands between the client and the real object, controlling how and when the real service is accessed.

## ✅ When to Use the Proxy Pattern
Use the Proxy Pattern when:

You want to control access to an object (e.g., role-based authorization).
You want to add caching to avoid repeated expensive calls.
You want to lazy-load or defer a heavy object until it’s really needed.
You want to log, monitor, or audit calls to a service without modifying the service.

## ✨ Features

Minimal API (Program.cs only)

Implements Proxy pattern with IWeatherService
Adds simple in-memory caching in the proxy
Console output to simulate real and cached responses

## 🎯 Goal
Expose a /weather/{city} endpoint. The proxy service adds caching and wraps the real weather service, demonstrating the Proxy Pattern in action.

## 📦 Requirements

- .NET 9 or later

## 🛠 How to Run

```bash
dotnet run
