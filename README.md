# ModernTlSharp
A .Net Core 3.1 copy of TLSharp with extensions for easier use...

this project is a port of _[TLSharp](https://github.com/sochix/TLSharp)_

## Differences

* Changed target framework to .Net Core 3.1
* Added Some extension methods and classes:
  * **`UpdateCatcher`** (_This can help you receive updates immediately and returns `TLDifference`_).
  * **`SendTextMessages`** (_Can be useful to sent text messages to supergroups and private chats easily_)
  * **`MakeSeen`** (_To mark messages history readed_)
  * Something more soon...
  
## Install

| _Package Manager_                              | _.Net Cli_                                         |
|:-----------------------------------------------|:---------------------------------------------------|
| `Install-Package ModernTlSharp -Version 1.2.4` | `dotnet add package ModernTlSharp --version 1.2.4` |

* _[Nuget page](https://www.nuget.org/packages/ModernTlSharp/)_

## Usage

After authorization you can call _`UpdateCatcher`_ extension method and pass a callback function to handle `Update (A of class of TLDifference)` (here is _UpdateCatched_).

Also I add a _MessageHandler_ method it easier to work with `Update`. you should change it depending on your need... (here we can handle texts from private and super-group chats in _`MessageHandler`_).

**Update object contains every new updates that catched from telegram.**

There is an example in project files (_ModernTLSharp.Test_)

### Example

#### ConsoleAuthocate:
```cs
//var auth = new ModernTlSharp.TLSharp.Extensions.Authorization(TelegramClient,
//    "+12345678998");

//await auth.ConsoleAuthocate();

Authorization auth = new ModernTlSharp.TLSharp.Extensions.Authorization(TelegramClient);

await auth.ConsoleAuthocate();
```

#### UpdateCatcher:
```cs
static async Task Main()
{
    TelegramClient = new TelegramClient(API_ID, API_HASH);

    await TelegramClient.ConnectAsync();

    //var auth = new ModernTlSharp.TLSharp.Extensions.Authorization(TelegramClient,
    //    "+12345678998");

    //await auth.ConsoleAuthocate();

    Authorization auth = new ModernTlSharp.TLSharp.Extensions.Authorization(TelegramClient);

    await auth.ConsoleAuthocate();

    await TelegramClient.UpdateCatcher(UpdateCatched);
}

private static async Task UpdateCatched(Update arg)
{
    //handel updates here!
}
```

