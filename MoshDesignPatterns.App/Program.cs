using MoshDesignPatterns.Domain;
using MoshDesignPatterns.Domain.Adapter;
using MoshDesignPatterns.Domain.Behavioral.Template;
using MoshDesignPatterns.Domain.Factory;
using MoshDesignPatterns.Domain.Prototype;
using MoshDesignPatterns.Domain.Singleton;
using MoshDesignPatterns.Domain.State;
using MoshDesignPatterns.Domain.Strategy;
using MoshDesignPatterns.Domain.Structural.Bridge.Demo;
using MoshDesignPatterns.Domain.Structural.Facade;

var patternToRun = "bridge";
patternToRun = patternToRun.ToLowerInvariant();


// state - Allows an object to behave differently depending on the state it is in
if (patternToRun == "state")
{
    var directionService = new DirectionService(new Bicycling());
    var eta = directionService.GetEta();
    var direction = directionService.GetDirection();
}

// strategy - Allows passing different algorithms (behaviors) to an object.  Allows
//            defining a template (skeleton) for an operation.  Specific steps will then be
//            implemented in subclasses.
if (patternToRun == "strategy")
{
    var chatClient = new ChatClient(new AESEncryption());
    chatClient.Send("MessageToEncrypt");
}

// template
if (patternToRun == "template")
{

}

// factory - Allows deferring the creation of an object to subclasses
if (patternToRun == "factory")
{
    var scheduler2 = new ArabianScheduler();
    scheduler2.Schedule(new Event());

    var scheduler3 = new Scheduler();
    scheduler3.Schedule(new Event());
}

// singleton - To ensure an object has only a single instance
if (patternToRun == "singleton")
{
    var logger1 = Logger.GetInstance("file1");
    var logger2 = Logger.GetInstance("file1");
    Console.WriteLine(logger1 == logger2);

    var logger3 = Logger.GetInstance("file2");
    Console.WriteLine(logger1 == logger3);
}

// prototype - To create new objects by copying an existing object
if (patternToRun == "prototype")
{
    var timeline = new Timeline();
    var text = new Text("Hello");
    timeline.Add(text);

    var contextMenu = new ContextMenu(timeline);
    contextMenu.Duplicate(text);
}

// adapter - Allows converting the inteface of a class into another interface that clients expect
if (patternToRun == "adapter")
{
    var emailClient = new EmailClient();
    emailClient.AddProvider(new GmailProvider(new GmailClient()));
    emailClient.DownloadEmails();
}

// facade - provides a simplified, higher-level interface to a subsystem. Clients can talk to the facade
//          rather than individual classes in the subsystem.
if (patternToRun == "facade")
{
    var twitterAPI = new TwitterAPI("appKey", "secret");
    twitterAPI.GetRecentTweets();
}

// template - allows defining a template (skeleton) for an operation.
//            Specific steps will then be implemented in subclasses.
if (patternToRun == "template")
{
    var guiWindow = new GUIWindow();
    guiWindow.Close();
}


if (patternToRun == "bridge")
{
    var advancedRemote = new AdvancedRemoteControl(new SamsungTV());
    var advancedRemote2 = new AdvancedRemoteControl(new SonyTV());

    advancedRemote.TurnOn();
    advancedRemote2.TurnOn();

    advancedRemote.TurnOff();
    advancedRemote2.TurnOff();
}
