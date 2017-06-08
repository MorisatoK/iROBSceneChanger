# iROBSceneChanger
Simple tool to control OBS via Websockets using the iRacing SDK

Out of personal requirements to switch between two scenes in OBS depending on being in our out of the car in iRacing I created this little tool. Because why remember to do it (you don't) when you can automate it?

## Requirements
In OBS you need the [OBS Websocket Plugin](https://github.com/Palakis/obs-websocket).

## Configuration
There is no configuration for the iRacing part, it always is looking for the driver (you). The OBS part is currently hardcoded (I'm lazy). However you can of course change the default values, but have to enter them again after a restart of the application. 
+ `IP:PORT` is the IP and Port configured for the Websocket server in OBS. *This can be running on another PC!* (but untested)
+ `Password` is the password configured for the Websocket server in OBS.
+ `In Car` is the name of the OBS scene that should be switched to when entering the car.
+ `Garage` is the name of the OBS scene that should be switched to when getting out of the car.

## Known bugs and/or limitations
There is some amount of sanity, but I would not assume all cases are covered. It's a personal project, and I know what I'm doing with it ;)  
The implementation of [obs-websocket-dotnet](https://github.com/Palakis/obs-websocket-dotnet) does not handle forceful disconnects very well (read: it doesn't at all). So if your OBS crashes most likely this app will crash too.
