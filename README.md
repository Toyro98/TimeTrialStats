# TimeTrialStats
A C# program to log your time trial stats. It shows your current, best, average, and total for the time trial you're currently playing.
It supports Steam, GoG, Origin, Reloaded, and Dvd version. Not only does it only log your finished runs, it also has a discord rich presence.

Reads the memory of the Mirror's Edge process every 100ms. Any lower than that would require more cpu usage.
If it uses a lot of your cpu, you can clone project and change it.

To enable discord rich presence, toggle format stats, or to view all runs. You right click and these options appears
You can save all your run logs after you're done. Once you clicked on View All Runs, you'll see all your runs on any map you played.
There you can save it into a json format which looks like this.
```json
[
  {
    "MapName": "Atrium One",
    "Time": 47.1401062,
    "AvgSpeed": 24.52914,
    "Distance": 321.1962
  },
  {
    "MapName": "Chase",
    "Time": 55.6147575,
    "AvgSpeed": 27.5162067,
    "Distance": 425.085327
  }
]
```

<br>

## UI

**With "Format Stats" on**<br>
![](https://i.imgur.com/Z8EaGxq.png)

<br>

**Without**<br>
![](https://i.imgur.com/8syMpA4.png)

<br>

**Stats Viewer (Format Stats on)**<br>
![](https://i.imgur.com/qFbEyj4.png)

<br>

**Discord Rich Presence**<br>
![](https://i.imgur.com/c05fRPs.png)
