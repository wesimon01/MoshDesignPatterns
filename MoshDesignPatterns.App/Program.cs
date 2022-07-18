using MoshDesignPatterns.Domain;
using MoshDesignPatterns.Domain.Factory;
using MoshDesignPatterns.Domain.Prototype;
using MoshDesignPatterns.Domain.Singleton;
using MoshDesignPatterns.Domain.State;
using MoshDesignPatterns.Domain.Strategy;

var patternToRun = "singleton";
patternToRun = patternToRun.ToLowerInvariant();


//state
if (patternToRun == "state")
{
    var directionService = new DirectionService(new Bicycling());
    var eta = directionService.GetEta();
    var direction = directionService.GetDirection();
}

//strategy
if (patternToRun == "strategy")
{
    var chatClient = new ChatClient(new AESEncryption());
    chatClient.Send("MessageToEncrypt");
}

//template
if (patternToRun == "template")
{

}

//factory
if (patternToRun == "factory")
{
    var scheduler2 = new ArabianScheduler();
    scheduler2.Schedule(new Event());

    var scheduler3 = new Scheduler();
    scheduler3.Schedule(new Event());
}

//singleton
if (patternToRun == "singleton")
{
    var logger1 = Logger.GetInstance("file1");
    var logger2 = Logger.GetInstance("file1");
    Console.WriteLine(logger1 == logger2);

    var logger3 = Logger.GetInstance("file2");
    Console.WriteLine(logger1 == logger3);
}

if (patternToRun == "prototype")
{
    var timeline = new Timeline();
    var text = new Text("Hello");
    timeline.Add(text);

    var contextMenu = new ContextMenu(timeline);
    contextMenu.Duplicate(text);
}

