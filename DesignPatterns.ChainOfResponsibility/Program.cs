

using DesignPatterns.ChainOfResponsibility;

var firstHandler = new FirstHandler();
var secondHandler = new SecondHandler();
var thirdHandler = new ThirdHandler();

firstHandler.SetNext(secondHandler);
secondHandler.SetNext(thirdHandler);

firstHandler.Handle("First");
secondHandler.Handle("Second");
thirdHandler.Handle("Third");