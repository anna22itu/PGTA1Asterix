# ASTERIX DECODER

### First Part: Codification

This branch is formed by 10 classes, which can be summarized in 7 topics.

1.	Read: in this class, the raw data is imported, and all the needed decoding methods are called.

2.	CAT10 & CAT21: in these two classes, the data items are decoded. The method is based in a “cases” structure, where a main function calls the needed method for every data item.

3.	Cat10Dict & Cat21Dict: as before every class is used for each category, and here there are many dictionaries defined in order to relate decoded values with the meaning information.

4.	Aircraft: this class is the constructor for every target decoded, where all the needed information for the Map View (such as: longitude, latitude, height, ID…) is loaded.

5.	Data: this class is called in order to store the already decoded data. The information is saved in a list of object arrays (each array being a data block, and each object being a data item).

6.	Functions: some needed functions such as converting from hexadecimal to binary, obtaining the Fspec of the data blocks, converting from binary to string…

7.	GeoUtils & GeneralMatrix: these both classes are given ones, used to transform the coordinates from cartesian to WGS-84, etc.


### Second Part: Simulator

The simulator contains a bar lateral main menu with which all the possible functions will be carried out, with its different buttons.


<img width="961" alt="Captura de pantalla (326)" src="https://user-images.githubusercontent.com/80980228/206442405-394b9deb-f071-4b5a-9295-c4b2c358d6fa.png">


First, we must load the data with which we will work. By clicking on the ‘Load File’ button, a tab will open in which we will have to locally select our file to read, as can be seen in the following figure:


<img width="960" alt="Captura de pantalla (327)" src="https://user-images.githubusercontent.com/80980228/206442434-27cd90c1-8ffb-4fa6-b199-50cc10b88475.png">


Following, we will see above in the upper panel the name of the selected file and with which we will work. Afterward, it will be explained why the checkbox of the selected type is marked.


<img width="960" alt="Captura de pantalla (328)" src="https://user-images.githubusercontent.com/80980228/206442463-f37fd389-47ed-45f4-850c-c4cd5a58f511.png">


Once the file with all the data has been loaded, we have different options; export the file, view the data, and load the map.

1. If we export the file, an excel file will be created in a new folder that you can choose, where all the data read from the loaded file will be shown in table form.


<img width="958" alt="Captura de pantalla (332)" src="https://user-images.githubusercontent.com/80980228/206442504-4cd314b2-8a54-4e10-b4c9-272905603bda.png">


2. Furthermore, if we want to display the data, we must click on the DataView button, which will open a new form with all the data.

Also, so that it is faster to load all the rows, at the beginning only 10,000 rows are loaded, we have created a button that loads 10,000 new lines each time.


<img width="960" alt="Captura de pantalla (355)" src="https://user-images.githubusercontent.com/80980228/206783627-c5b6f4f2-2d99-4813-8e35-f7b1c16bbe0d.png">


Also, due to a large amount of data, there is the possibility of filtering. We have two different ways.

First, show the most relevant data or show all of them, through the checkboxes on the left.

Second, by selecting a feature, for example, Target Identification, and clicking on the magnifying glass, a drop-down will open where you can enter the value of a Taget Identification, e.g. 'F19'.


<img width="960" alt="Captura de pantalla (357)" src="https://user-images.githubusercontent.com/80980228/206783657-1101f9d6-7f7f-4f9a-bbeb-169c52ec3ac4.png">


As a result, we will get all the rows with a Target Identification value equal to the one entered ('F19'). We see an example in the following figure.



<img width="960" alt="Captura de pantalla (356)" src="https://user-images.githubusercontent.com/80980228/206783676-23caa031-97b3-4f47-864e-275568a19108.png">



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

Finally, if you click on an aircraft, on the left of the map will appear an informative table, with the main characteristics of that aircraft; the ICAO Id, the TrackNumber, the SAC, the SIC, the Flight Level and the GroundSpeed. Also, above the map will appear the latitude and longitude values of the selected aircraft.


<img width="960" alt="Captura de pantalla (344)" src="https://user-images.githubusercontent.com/80980228/206485901-4486a6be-08c1-4a55-95c8-46df439700e3.png">


In addition, we have two extra buttons; the AboutUs button and the Info button. The AboutUs is to know a little more about us, to know who we are, and the reason for this project. The Info button sends you to this readme in which the operation of the entire simulator is explained step by step.


<img width="961" alt="Captura de pantalla (326)" src="https://user-images.githubusercontent.com/80980228/206486706-ff95892c-fa2f-4ef6-8493-a63e10908b0f.png">

