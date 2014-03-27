# SkyDrive Download Files Name Encoding Error Renamer

**************
This project is written with C# in VisualStudio 2012 by Adil: <adilahun@hotmail.com>
**************

This is the first version of this little app.
It's for who you download files (folders) from SkyDrive (now as OneDrive) as a zip file and in the .zip file had a text file named "Encoding Error.txt".
[Like in this link](Https://skydrive.live.com/redir?resid=D6F844C80E6EF1C!115&authkey=!AE3yueQIrpzhw‏)
In that text file says: 
**"Due to the limitations of the supported zip file format, the following file(s) had to be renamed."** 
and other files all get the serial names like:

 * file1.mp3
 + file2.mp3
 - file3.pdf
 * ... etc.

This little app can get these files get back the original names with the "Encoding Error.txt" file. 
Maybe you don't have these kind problems and you don't want to use this app. 

***************

## ‫SkyDrive (ھازىرقى ئىسمى OneDrive) دىن چۈشۈرگەن ھۆججەتنىڭ ئىسمىنى ئەسلىگە كەلتۈرگۈچ

بۇنى ‫SkyDrive دىن ھۆججەت ۋە ھۆججەت قىسقۇچلارنى چۈشۈرگەندە ئىسمى ئۆزگىرىپ كېتىشنى ئوڭشاش ئۈچۈن ياسىغان.
بەزىدە  ‫SkyDrive دىن بىر قانچە ھۆججەتنى ياكى ھۆججەت قىسقۇچنى بىراقلا چۈشۈرگەندە .zip ھۆججىتى قىلىپ چۈشۈرۈپ بېرىدىكەن، لېكىن ئارىسىدا ھۆججەتلەرگە ئۇيغۇرچە، ئەرەبچە يېزىقلاردا ئىسىم قويۇلغان بولسا، بۇ ھۆججەتلەرنىڭ ۋە ھۆججەت قىسقۇچلارنى ئىسمىنى ئاپتوماتىك file1.mp3, file2.mp3, file3.mp3, file4.pdf, ...دېگەندەك ئىسىملارغا ئۆزگەرتىۋىتىدىكەن. بۇ چاغدا بىز قايسى ھۆججەتنىڭ ئەسلىدىكى ئىسمى قايسى ئىكەنلىكىنى ئايرىش ئۈچۈن بىردىن ئېچىپ بىقىشقا توغرا كىلىدىكەن.
مەسىلەن: [بۇ ئۇلىنىشتىكى ھۆججەتلەرنى ياكى ھۆججەت قىسقۇچنى بىراقلا تاللاپ چۈشۈرسىڭىز](Https://skydrive.live.com/redir?resid=D6F844C80E6EF1C!115&authkey=!AE3yueQIrpzhw‏)
لېكىن دىققەت قىلساق شۇ بىز چۈشۈرگەن .zip ھۆججىتىنىڭ ئىچىدە يەنە بىر تېكسىت ھۆججىتىمۇ قوشۇلۇپ قالغان بولۇپ، بۇ ھۆججەتنىڭ بېشىدا ئادەتتە مۇنداق يېزىلغان:
**"Due to the limitations of the supported zip file format, the following file(s) had to be renamed."**
مەنىسى: zip ھۆججىتىنى قوللاش جەھەتتىكى چەكلىمىلەر تۈپەيلى، تۆۋەندىكى ھۆججەتلەرنىڭ ئىسمى ئۆزگەرتىلدى.
ئاستىدا ھۆججەتلەرنىڭ ئەسلىدىكى ئىسمى ۋە ئۆزگەرتىلگەن ئىسىملىرى بېرىلگەن بولۇپ، مۇشۇنىڭغا ئاساسەن بىز ھۆججەتلەرنىڭ ئىسمىنى ئەسلىگە كەلتۈرىۋالساق بولىدۇ.
ئەگەر ھۆججەت سانى كۆپ بولسا ۋە بىر مۇنچە ھۆججەت قىسقۇچلاردا بولسا بىر-بىرلەپ ئىسىم ئۆزگەرتىپ چىقىش سەل ئاۋارىچىلىق بولىدىكەن. شۇڭا مۇشۇنى ھەل قىلىش ئۈچۈن بۇنى ياساپ باقتىم. مۇشۇنداق ئەھۋالغا ئۇچرىغانلارغا  ئاز-تولا ياردىمى تېگىپ قالسا ئەجەپ ئەمەس دەپ تورغا يوللاپ قويدۇم.
‫بۇنى VisualStudio 2012 دە C# تا يازغان. ‫WPF نى تۇنجى ئىشلىتىشىم بولغاچقا ئانچە چىرايلىق چىقمىدى. قىزىقىدىغانلار كودىنى چۈشۈرۈپ ئۆزگەرتىپ ياخشىلاپ باقسا بولىدۇ.
‫خەت نۇسخىسى ئۈچۈن ئاندروئىدنىڭ سۈكۈتتىكى خەت نۇسخىسى بولغان Droid Naskh Shift Alt نى ئىشلەتكەن، ئەگەر كومپيۇتېرىڭىزدا ئۇ خەت نۇسخىسى بولمىسا، ئۇنى [بۇ يەردىن](https://raw.githubusercontent.com/sunsiz/SkyDrive_Error_Renamer/master/DroidNaskh-Regular-SystemUI.ttf) چۈشۈرۈپ قاچىلاڭ ياكى ئەسلى كودتىن خەت نۇسخىسىنى ئالماشتۇرىۋىتىڭ.

### ئېكران كۆرۈنىشى 1

![ئېكران كۆرۈنىشى](https://raw.githubusercontent.com/sunsiz/SkyDrive_Error_Renamer/master/screenshots/WindowScreenshot.jpg)

### ئېكران كۆرۈنىشى 2

![ئېكران كۆرۈنىشى](https://raw.githubusercontent.com/sunsiz/SkyDrive_Error_Renamer/master/screenshots/WindowScreenshot1.jpg)

### ئېكران كۆرۈنىشى 3

![ئېكران كۆرۈنىشى](https://raw.githubusercontent.com/sunsiz/SkyDrive_Error_Renamer/master/screenshots/WindowScreenshot2.jpg)


## ئىشلىتىش ئۇسۇلى
1. ئاۋۋال چۈشۈرگەن zip ھۆججىتىنى يېشىڭ.
2. ئاندىن بۇ پروگراممىنى قوزغىتىپ، ھۆججەت تاللاش دىئالوگ رامكىسىدىن «ھۆججەت ئېچىش» كۇنۇپكىسىنى بېسىپ، zip ھۆججىتىنى يەشكەن ئورۇننى ئېچىپ، Encoding Error.txt ھۆججىتىنى تاللاپ ئېچىڭ.
3. بۇ چاغدا پروگرامما ئۇ ھۆججەتتىن ھۆججەتلەرنىڭ ھازىرقى ۋە ئەسلىدىكى ئىسىملىرىنى پروگرامما تىزىملىكىگە ئوقۇپ ئەكىرىدۇ.
4. ئاندىن «ئىسمىنى ئۆزگەرتىش» كۇنۇپكىسىنى باسسىڭىز، ئىسىم ئۆزگەرتىشنى باشلايدۇ. تاماملانغاندا كۇنۇپكىنىڭ ئاستى تەرىپىدە «ھەممىنى تۈگەتتىم» دېگەن خەت چىقىدۇ.
شۇنىڭ بىلەن zip ھۆججىتىنى يەشكەن ئورۇنغا قارىسىڭز ھۆججەتلىرىڭىز ۋە ھۆججەت قىسقۇچلىرىڭىزنىڭ ئىسمى ئۆزگىرىپ بولغانلىقىنى كۆرەلەيسىز. بۇ چاغدا SkyDrive ئىسمىنى 1،2،3،4،... قىلىپ ئۆزگەرتىۋەتكەن ھۆججەت قىسقۇچلارنى ئاچسىڭىز ھەممىسى قۇپقۇرۇق بولۇپ، بۇلارنى خاتىرجەم ئۆچۈرىۋەتسىڭىز بولىدۇ.