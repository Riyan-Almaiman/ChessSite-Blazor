# ChessSite-Blazor

Using the logic I wrote in my console chess app to write a web app with Blazor.

you can try it here https://shtranj.azurewebsites.net but I should emphasize it's very much a WIP, especially the UI and the join/create logic because there is no database and it uses the in-app memory to keep track of the lobbies and the tier I used on azure for some reason doesn't keep track of the singleton(list of lobbies) idk why

there's also no logic for when a client disconnects - there should be a function in the hub to catch a disconnect and remove the connection id from the lobby so they can join back. Also lobby states aren't kept track currently on the server, so joining back doesn't work right currently. 
