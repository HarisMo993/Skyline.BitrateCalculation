# Skyline.BitrateCalculation without SLC.LIB.Automation NuGet package

This project I was working on was an assignment from Skyline Communications. Likewise, it is about bitrate calculation where I had json data with the help of which I had to add additional RX and TX bitrates. The task was successfully completed, and with this file you would go through the work on the task.


## Task Desctiption

### Bitrate calculation exercise

Imagine the vendor Arista had a video transcoder known as X-Video. For each network interface included in X-Video, the API returns the number of transmitted and received octets at a determined moment. Our customer 
Fox is using several of that equipment and asked Skyline to add the respective bitrates, Rx and Tx, to the current 
driver.
Exercise: parse the following JSON and implement a method to calculate the requested bitrates for both Rx and 
Tx considering a pooling rate of 2Hz.
Use the programming language at your preference. C# would be an added-value.

![1](https://user-images.githubusercontent.com/80532396/216826514-7ece68d0-7b8e-4849-b2f8-c3fce6a760b0.PNG)


## 🛠️ Installation Steps

1. Clone the repositorty
  https://github.com/HarisMo993/Skyline.BitrateCalculation/tree/feature/witout-scl-lib-automation-nuget-package
2. Before running the project, run Build Solution first because of that they pull all nuget packages included in the project.
3. This is it project start the project

![2](https://user-images.githubusercontent.com/80532396/216828386-f1537e03-7199-4c1f-b734-e31cac5a289c.PNG)


## 📖 Description how to use the app

* When the application is opened, we have a display as we can see in the picture above.

* There we have classic CRUD operations written in the ASP.NET Core API project.
  - C - Create
  - R - Read
  - U - Update
  - D - Delete

* The first operation we will describe is Create (Post method)

  ![image](https://user-images.githubusercontent.com/80532396/216829529-c8845453-b772-424d-a47b-e0fade7a1387.png)
  
  - In the Example value column, enter json string data like this, for example: 
  
        "{__
            \"Device\":\"Arista\",__
            \"Model\":\"X-Video\",__
            \"NIC\":[{__
                   \"Description\":\"Linksys ABR\",__
                   \"MAC\":\"14:91:82:3C:D6:7D\",__
                   \"Timestamp\":\"2020-03-23T18:25:43.511Z\",__
                   \"Rx\":\"3698574500\",__
                   \"Tx\":\"122558800\"__
                   }]__
         }"__
         
 - After that when we click Execute we get codes 200 that it went as it should and we have the data printed in json format like on the picture.
 
 
