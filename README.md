**ASTERIX DECODER**

First Part: Codification

Second Part: Simulator

The simulator contains a bar lateral main menu with which all the possible functions will be carried out, with its different buttons.


<img width="961" alt="Captura de pantalla (326)" src="https://user-images.githubusercontent.com/80980228/206442405-394b9deb-f071-4b5a-9295-c4b2c358d6fa.png">


First, we must load the data with which we will work. By clicking on the ‘Load File’ button, a tab will open in which we will have to locally select our file to read, as can be seen in the following figure:


<img width="960" alt="Captura de pantalla (327)" src="https://user-images.githubusercontent.com/80980228/206442434-27cd90c1-8ffb-4fa6-b199-50cc10b88475.png">


Following, we will see above in the upper panel the name of the selected file and with which we will work. Afterward, it will be explained why the checkbox of the selected type is marked.


<img width="960" alt="Captura de pantalla (328)" src="https://user-images.githubusercontent.com/80980228/206442463-f37fd389-47ed-45f4-850c-c4cd5a58f511.png">


Once the file with all the data has been loaded, we have different options; export the file, view the data, and load the map.

1. If we export the file, an excel file will be created in a new folder that you can choose, where all the data read from the loaded file will be shown in table form.


<img width="958" alt="Captura de pantalla (332)" src="https://user-images.githubusercontent.com/80980228/206442504-4cd314b2-8a54-4e10-b4c9-272905603bda.png">


2. Furthermore, if we want to display the data, we must click on the DataView button, which will open a new form with all the data:


<img width="960" alt="Captura de pantalla (329)" src="https://user-images.githubusercontent.com/80980228/206442593-283f0578-02f3-4a4e-95e6-476231aa48fa.png">


Also, due to a large amount of data, there is the possibility of filtering. We have two different ways.

First, show the most relevant data or show all of them, through the checkboxes on the left.

Second, by selecting a feature, for example, Target Identification, and clicking on the magnifying glass, a drop-down will open where you can enter the value of the track Number.


<img width="960" alt="Captura de pantalla (330)" src="https://user-images.githubusercontent.com/80980228/206442682-01490501-6a65-469f-8cb2-9a642d3b87fc.png">


As a result, we will get all the rows with a Track Number value equal to the one entered. We see an example in the following figure.


<img width="960" alt="Captura de pantalla (331)" src="https://user-images.githubusercontent.com/80980228/206442713-851f1593-c0b8-4ddf-9b47-f0a763c30dd2.png">


3. In addition, we have the simulator part, in which we have the aircraft visible on the map.
When we click on the Map View button, the map will no longer be blurred and, we can start the simulation if we wish. Depending on the file that we select, some aircraft or others will appear, by clicking the Play button, as we can see at the following figure.


<img width="960" alt="Captura de pantalla (335)" src="https://user-images.githubusercontent.com/80980228/206444059-4061c90f-334f-4b5b-bb4d-d69732a2e056.png">


At the top right, it will appears a label that tells us the time of the simulation, and it starts the first time that the data shows when we load the file and the map.


On the left side of the simulator, we find the three checkboxes mentioned above. If they are not selected, all aircraft of that type will no longer be visible. For example, if we load the file with the three types, as we will see below, it will be helpful to stop viewing some aircraft.

<img width="960" alt="Captura de pantalla (339)" src="https://user-images.githubusercontent.com/80980228/206451893-42b8064c-f587-4a5f-8f7b-026a7e13fb3e.png">


Now we see if we unclick the MLAT checkbox, all MLAT aircraft will disappear.


<img width="960" alt="Captura de pantalla (340)" src="https://user-images.githubusercontent.com/80980228/206452245-fc6ce185-27b2-4b27-8d08-beafab7af2c5.png">


Also, there is the possibility of entering some ID of an aircraft currently flying and zooming in on it, eliminating all the others. Thereby, a help button has been created, called Show List, which tells you the ID of all the planes present on the map.


<img width="960" alt="Captura de pantalla (337)" src="https://user-images.githubusercontent.com/80980228/206452328-fbcbd12c-8d68-4b47-97a9-530afb9a58c2.png">


Now we see only the aircraft selected on the map.


<img width="960" alt="Captura de pantalla (338)" src="https://user-images.githubusercontent.com/80980228/206452422-5f15e91e-3eff-48e6-82f7-36240c184bcf.png">


Further, we have the possibility to change the Google map view to the Satellite map view, by clicking the Satellite button. As we can see in the following figure.


<img width="960" alt="Captura de pantalla (336)" src="https://user-images.githubusercontent.com/80980228/206447050-d600b5cf-2e37-474d-8fb0-790281c24727.png">


Further, we have a Reload button in which the map will start again, it will eliminate all aircraft and will reload one more time all aircraft.


<img width="960" alt="Captura de pantalla (343)" src="https://user-images.githubusercontent.com/80980228/206453440-f9ea6f4b-187e-407a-a7cd-ebd70fa974fd.png">


Moreover, different buttons have been implemented, with which to interact with the map. At the bottom left, we have the time scale, which gives us four levels of simulation speed (x0.5, x1, x1.25, x1.5). 

Also, we have three additional buttons that make the simulation easier. If we un-zoom the initial area of the map, we can return to different areas on the map; the LEBL button will zoom at the Barcelona airport, the BCN button will zoom at Barcelona city and, the CAT button will zoom at Catalonia. 


<img width="960" alt="Captura de pantalla (342)" src="https://user-images.githubusercontent.com/80980228/206447780-7a37f9a5-b549-4e17-9320-c3c063c6dd3f.png">

Finally, if you click on an aircraft, on the left of the map will appear an informative table, with the main characteristics of that aircraft; the ICAO Id, the TrackNumber, the SAC, the SIC, the Flight Level and the GroundSpeed.


<img width="960" alt="Captura de pantalla (344)" src="https://user-images.githubusercontent.com/80980228/206485901-4486a6be-08c1-4a55-95c8-46df439700e3.png">


In addition, we have two extra buttons; the AboutUs button and the Info button. The AboutUs is to know a little more about us, to know who we are, and the reason for this project. The Info button sends you to this readme in which the operation of the entire simulator is explained step by step.


<img width="961" alt="Captura de pantalla (326)" src="https://user-images.githubusercontent.com/80980228/206486706-ff95892c-fa2f-4ef6-8493-a63e10908b0f.png">

