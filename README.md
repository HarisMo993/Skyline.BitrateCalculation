# Skyline.BitrateCalculation without SLC.LIB.Automation NuGet package

This project I was working on was an assignment from Skyline Communications. Likewise, it is about bitrate calculation where I had json data with the help of which I had to add additional RX and TX bitrates. The task was successfully completed, and with this file you would go through the work on the task.


## 🛠️ Installation Steps
1. Use Visual Studio 2022
2. Clone the repositorty.
  https://github.com/HarisMo993/Skyline.BitrateCalculation/tree/feature/witout-scl-lib-automation-nuget-package
3. Before starting the project, run Build Solution first in order to pull all of the nuget packages used in this project.
4. This is it, we can start the project.

![2](https://user-images.githubusercontent.com/80532396/216828386-f1537e03-7199-4c1f-b734-e31cac5a289c.PNG)


## 📖 Description how to use the app

* When the application is opened, we have a display as we can see in the picture above.

* There we have classic CRUD operations written in the ASP.NET Core API project.
  - C - Create
  - R - Read
  - U - Update
  - D - Delete

* The first operation we will describe is Create (Post)

  ![image](https://user-images.githubusercontent.com/80532396/216829529-c8845453-b772-424d-a47b-e0fade7a1387.png)

  - In the Example value column, enter json string data like this, for example: 

        "{
            \"Device\":\"Arista\", 
            \"Model\":\"X-Video\", 
            \"NIC\":[{ 
                   \"Description\":\"Linksys ABR\", 
                   \"MAC\":\"14:91:82:3C:D6:7D\", 
                   \"Timestamp\":\"2020-03-23T18:25:43.511Z\", 
                   \"Rx\":\"3698574500\", 
                   \"Tx\":\"122558800\" 
                   }] 
         }" 

  - After that when we click Execute we get codes 200 that it went as it should and we have the data printed in json format like on the picture.

  ![3](https://user-images.githubusercontent.com/80532396/216831732-f4e98a55-14d9-440a-a978-02838c83d572.PNG)

  - So with this we can see that the post method was executed successfully.

* The second operation we will describle is Read (Get)

  ![image](https://user-images.githubusercontent.com/80532396/216832146-70786a16-8084-4475-ad33-e65b4717d08e.png)

  - As we can see, this operation has no parameters, so we don't have to enter anything, we just need to execute it.

  ![image](https://user-images.githubusercontent.com/80532396/216832214-03649682-d76a-42d3-93b0-cdeff106e83f.png)

* The third operation is the same as the second, only that here we have to send a parameter to get the data (Get/{id}).

  ![image](https://user-images.githubusercontent.com/80532396/216832369-b0a95b1b-ebf8-44cd-b60c-f7a431bb89bb.png)

  ![image](https://user-images.githubusercontent.com/80532396/216832396-bde57c85-f398-4149-8d13-ff7bb192e719.png)

* The fourth operation is update (Put)

  ![image](https://user-images.githubusercontent.com/80532396/216832547-aa7db7ca-45e9-43a9-b8ad-a4ea31061c2d.png)

  - Update works by sending the parameter and the data we want to change and then executing it like on the picture.

  ![image](https://user-images.githubusercontent.com/80532396/216832669-836dff90-691c-4b7c-8ea4-8c2344bfbbf9.png)

  ![image](https://user-images.githubusercontent.com/80532396/216832687-151c51fd-8ca4-4a16-903f-4ce1c0f3daeb.png)

  - **Note**: Here we have two conditions for the NIC class when we want to update the data for the NIC, if the MAC addresses match, it will update the preceding NIC                 that is in the list, if there is no data in the NIC with the same MAC address, that data will be added to the list.

* Finally the delete operation (Delete)

  ![image](https://user-images.githubusercontent.com/80532396/216832984-e9273932-036a-4231-a942-c137d3e15955.png)

  - Receives one parameter and deletes the data if it finds it.

  ![image](https://user-images.githubusercontent.com/80532396/216833074-eaabefa6-1680-4cf5-bc73-f0e9a8ca9a3a.png)
