# Double Dispatch in C#

This repository showcases the implementation of double dispatch in C# through a hands-on example. The aim is to provide a deeper understanding of double dispatch concepts and their practical applications, ultimately enabling developers to write more adaptable and maintainable code.

## A Payment Provider Example

Imagine a payment provider that incurs fees based on various payment methods. Each method—be it credit cards, digital wallets, or bank transfers—has its own fee structure influenced by geographical and regulatory factors.

In this repository, we will define multiple payment types and demonstrate how to calculate their fees under different conditions. Starting with a straightforward implementation, we will progressively tackle more intricate scenarios where various payment methods interact with distinct regions. This exploration will illuminate how double dispatch can be effectively simulated in C#, allowing for behavior that adapts to runtime type information and utilizes late binding.

## Navigating Implementation Steps with Git Tags

To facilitate exploration of the implementation steps, this repository uses Git tags. Each tag represents a specific milestone in the development process. You can reset to a particular tag to view the code at that point. Here are the available tags:

- `single-dispatch`: Initial implementation showcasing single dispatch.
- `double-dispatch-type-checks`: Implementation demonstrating explicit type checks for double dispatch.
- `double-dispatch-base-payment`: Introduction of a base payment class for double dispatch.
- `double-dispatch-virtual-method-table`: Implementation utilizing a virtual method table to achieve double dispatch.
- `double-dispatch-dynamic`: Implementation using dynamic types to achieve double dispatch.
- `double-dispatch-visitor`: Final implementation showcasing the visitor pattern for double dispatch.

### How to Use Tags

To navigate between the implementation steps:

1. **List Tags**:
   
   Run the following command to see all available tags:

   git tag

3. **Checkout a Tag**:
   
   To view the code at a specific step, use the checkout command:

   git checkout `tag name`

## Repository Structure ##

- /src: Contains the main code implementation for the double dispatch example.
- /tests: Contains unit tests to verify the functionality of the code.

## License ##
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgments ##
Thanks for checking out this project! Feel free to explore the code and learn more about double dispatch in C#.
