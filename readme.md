# Unit Test Project Structure - Medium

---

This repository is made for my Medium blog post titled Unit Tests - Where Do You Put 'Em? - C# Example

This repository contains examples of a different approach to the standard unit test project and logic code project for .NET Core and .NET Framework.

This approach allows tests and logic code to sit side by side together, this allows tests to be maintained with ease and allows finding the specific test class a breeze. Test packages and test code itself is excluded on release builds, so you don't have to worry about test code creeping into your project's build output