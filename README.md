# scouting-server
Scouting server app for Alpha Dogs

Hello there traveler! <br/> 
Here's what to do with the server: <br/> 
 <br/> 
Prerequisites:  <br/> 
.Net 5.0 (5.017 is fine) <br/> 
Visual Studio Community 2022 <br/> 
A completed scouting form for the scouting app (just saves time) <br/> 
<br/> 
What to do: <br/> 
Open up the app in Visual Studio as a solution (.sln)<br/> 
Locate both MainMessage.cs and PitMessage.cs <br/> 
Edit the data from both respective files (swap out the names and add/remove any variables from the array to match your scouting form) <br/> 
Note: The order of the data in the message arrays must be the EXACT SAME as your scouting form, or data will be mismatched/lost <br/> 
Run the entire app from MainForm.cs <br/> 
If there are any errors, try to fix them to the best of your ability <br/> 
Once that copy of the server works, simply push it as a branch that's named the year of the server (i.e the 2026 server will just be a branch called 2026 <br/> 
 <br/> 
The server's running, now what: <br/> 
The app will display your computer's Mac Address in the formatting we need <br/> 
Assuming you're using the 2025 scouting server code for the app, replace the Mac Address under the string computerAddress with the current computer's (This will make the tablets auto-fill the previous address with your current one, so later on you don't have to fill it in every time). <br/> 
 <br/> 
I've got the server AND app working, how do I connect them? <br/> 
Before trying to send, ensure that the server computer and the tablet(s) have previously connected at least once through Bluetooth. This allows sending permissions. <br/> 
Ensure the Pit/Main button is the same as the app you're connecting to, then hit the run button on the server and choose the directory for the CSV file to be saved, this file contains every piece of match data. <br/> 
Once the server is running and the tablets are ready, simply hit the run button with data. (IMPORTANT: The server can only handle up to 4 tablets sending at once, reccomended to do in groups of 3). <br/> 
Note: Under connections, however many rows are being filled with text indicate the number of connections. <br/> 
 <br/> 
 Everything works, but it's not an app I can pass around. How do I make it one? <br/> 
 First, change the debug dropdown beside the CPU options and below the build button at the top to "Release." This makes Visual Studio build the app as normal, without the debugging functions.<br/> 
 Once you've done that, run WindowedApplication without debugging (the hollow play button) to both test and ensure it's running correctly<br/> 
 After that, right click on WindowedApplication in Solution Explorer, click "Open folder in File Explorer," open the "bin" folder, open the "Release" and then the "net5.0-windows" folder.<br/> 
 After ensuring there is data within the folder and the exe file runs correctly, compress the "net5.0-windows" folder to a zip file and you have your server as a transferable file.<br/> 
Last Updated: April  8th - 2025
