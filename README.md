**PGTA ASTERIX DECODER PROJECT**

First Part: Codification

Second Part: Simulator

The simulator contains a bar lateral main menu with which all the possible functions will be carried out, with its different buttons.


<img width="782" alt="Captura de pantalla 2022-12-02 153834" src="https://user-images.githubusercontent.com/80980228/205318570-c8fbdb73-f0dd-4fec-ad6b-7d3df4b22b8a.png">


First, we must load the data with which we will work. By clicking on the ‘Load File’ button, a tab will open in which we will have to locally select our file to read, as can be seen in the following figure:


<img width="960" alt="Captura de pantalla 2022-12-02 154032" src="https://user-images.githubusercontent.com/80980228/205320536-e02852e1-c5d5-44ba-bc95-cffd1054d89f.png">


Once the file with all the data has been loaded, we have different options; export the file, view the data, and load the map.

1. If we export the file, an excel file will be created in a new folder that you can choose, where all the data read from the loaded file will be shown in table form.


<img width="960" alt="Captura de pantalla 2022-12-02 154744" src="https://user-images.githubusercontent.com/80980228/205321326-0cba8576-ea20-4232-bc3a-6a17109776a7.png">


2. Furthermore, if we want to display the data, we must click on the DataView button, which will open a new form with all the data:


![Captura de pantalla (304)](https://user-images.githubusercontent.com/80980228/205325008-7cc0224d-611a-4f1a-bee1-2309bbabf258.png)


Also, due to a large amount of data, there is the possibility of filtering. We have two different ways.

First, show the most relevant data or show all of them, through the checkboxes on the left.

Second, by selecting a feature, for example, Track Number, and clicking on the magnifying glass, a drop-down will open where you can enter the value of the track Number. As a result, we will get all the rows with a Track Number value equal to the one entered. We see an example in the following figure.


<img width="960" alt="Captura de pantalla (306)" src="https://user-images.githubusercontent.com/80980228/205325098-3b65618c-9e2f-4928-b9ea-31a662990573.png">




In addition, we have the simulator part, in which we have the aircraft visible on the map. Depending on the file that we select, when we click on the Play button, some aircraft or others will appear.

At the top right, we have a label that tells us the time of the simulation, and it starts the first time that the data shows when we load the file and the map.

On the left side, once we select a specific aircraft, the data of that aircraft will appear.

Also, different buttons have been implemented, with which to interact with the map. At the bottom left, we have the time scale, which gives us three levels of simulation speed (x0.5, x1, x1.25).
In addition, we have a Reload button in which the aircraft return to their starting position. 
On the other hand, if we un-zoom the initial area of the map, we can return to the Barcelona airport by clicking on the LEBL button.
Finally, we have implemented a KML.





In addition, we have a button to know a little more about us, to know who we are, and the reason for this project.
