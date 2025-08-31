# ReadWriteCookiesInServerSideBlazor

I have a need to read and write cookies in a Blazor Server application. I asked a friend of mine, Rob Garner, for assistance when I shared an example that I'd come up with. He provided a solution in a [blog post he wrote](https://robgarnerblog.wordpress.com/2025/05/31/how-to-write-and-read-cookies-in-blazor/) that I have adapted to my needs. The code is available in this repository. 

## .NET 9

I used .NET 9 to create this project. I chose the Blazor Web App template when I created this project in Visual Studio 2022.

## Background

I want to be able to read and write cookies in a Blazor Server application. I have a need to store some data in cookies that I can read later. I also want to be able to write cookies that can be read by the client.

### Testing 1

I want to see if simply assigning a PR to someone (me in this case) is sufficient to get an email.