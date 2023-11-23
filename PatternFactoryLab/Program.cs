using PatternFactoryLab;

// Prompt the user to enter the type of question
Console.Write("Enter the type of question (cards, deposits, loans): ");

// Read the user's input and store it in the 'request' variable
string request = Console.ReadLine();

// Create an instance of the BankManagerFactory.
BankManagerFactory managerFactory = new BankManagerFactory();
// Use the factory to create an IBankManager based on the user's input.
IBankManager manager = managerFactory.CreateManager(request);
// Call the processClientRequest method on the created manager.
manager.processСlientRequest();
Console.ReadKey();
