## Augmented Reality Ads 


Please click to watch the overview video.

[![ScreenShot](https://github.com/RoshanRShetty/Augmented-Reality-Advertisements/blob/master/snapshot.PNG](https://github.com/RoshanRShetty/Augmented-Reality-Advertisements/blob/master/AR%20Demo.mp4)

**Visualization Link:** https://roshanrshetty.github.io/Project1/presentation%20layer/project1.1.html

### Data Description

The data set used for visualization are:
 - State wise unemployment rates,
 - National unemployment rates.
 
The ***state wise unemployment rates*** dataset has been downloaded from https://piazza.com/class/issa77pf63o6oc?cid=12. The ***national unemployment rate*** dataset has been downloaded from http://data.bls.gov/timeseries/LNU04000000. The time range for both the above data sets is from 1st January 1976 to 31st July 2016 provided by the *Bureau of Labor Statistics*. A snapshot of the data is as follows:

![ScreenShot](http://roshanrshetty.github.io/Project1/State wise unemployment rate.PNG)

![ScreenShot](http://roshanrshetty.github.io/Project1/National Unemployment rate.PNG)



###Data Preprocessing###

The data avaialble had to be reformatted to be used for the visualization. The data was processed as follows:

***- Data Cleaning and Formatting***

1. The first step was to replace the month values represented as 'text' to it's corresponding numeric value. For example January was replaced with 1, May with 5 and so on.

2. The next step was to sort the dataset according to the ascending order of the year and months. This was done using the 'sort' functionality provided by Microsoft Excel.

***- Data Sepration***

1. The next steps was to seprate all the data for different states to different sheets in excel. This was done using 'Kutools' software.

2. Finally the seprate sheets were stored as different .csv files. I have used the following tutorial to do the same: https://www.youtube.com/watch?v=hnsL_01bHbU. The code for the macro is as follows:

  ```

    Sub Splitbook()
    MyPath = ThisWorkbook.Path
    For Each sht In ThisWorkbook.Sheets
    sht.Copy
    ActiveSheet.Cells.Copy
    ActiveSheet.Cells.PasteSpecial Paste:=xlPasteValues
    ActiveSheet.Cells.PasteSpecial Paste:=xlPasteFormats
    ActiveWorkbook.SaveAs _
    Filename:=MyPath & "\" & sht.Name & ".xls" & FileFormat:=xlCSV
    ActiveWorkbook.Close savechanges:=False
    Next sht
    End Sub

  ```

### Intresting Findings

Some of the interesting findings that were visible with are visualization are as follows:

**1. Two Major Unemployment Peaks**
The two major unemployment peaks between 1980-1985 and 2008-2012 are the most prominent in the visualization. The former was during the 'Great Depression' of the 1980s and the later was during the latest 'Great Recession'.

![ScreenShot](http://roshanrshetty.github.io/Project1/finding1.png)

**2. Not all states were affected the same**

The effect of the 'Great Recession' was not uniform throughout US. Some states were affected more as compared to the other states. As shown in the image below, unemployment rate increased drastically in California as compared to Texas. The major industry of the state played a major role during the recession. States that were majorly dependent on Construction, Manufacturing and Automobiles were hit badly by the recession. 

![ScreenShot](http://roshanrshetty.github.io/Project1/finding2.png)

**3. The Housing Market Crash was a major reason for the spike in unemployment rate during the recession**

The 5 most affected states during the great recession were Nevada, Michigan, California, Florida and Rhodes Island. All 5 were amongst the top losers during the Hosuing Bubble Crash.





