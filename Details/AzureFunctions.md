# Introduction
This file describes a small demo using Azure Functions and Visual Studio 2019. It demonstrates the following:
   * Send message to the Azure Monitor Invocation Details As a JSON Object
   * Send message to the Azure Monitor Invocation Details As a string (using some informations sent in the JSON Object)
   * Export excel spreadsheet to a generated XML file.


# What I learned about Azure Functions
   * Gives the ability to run custom code on demand and at scale on the cloud
   * Supports many languages (C#, Java, JavaScript, Python, and PowerShell)
   * There are multiple redundancies in place to maintain data access
   * Possibility to automate many repetitive tasks (Like in this demo)
   * It is Open-source
   * It is affordable



# Images

### Create Project in Visual Studio 2019
 ![Create Project](https://github.com/camillebalima/AzureDemo/blob/master/Images/CreateProject.PNG)
 
### Create First Azure Function
 ![Create First Azure Function](https://github.com/camillebalima/AzureDemo/blob/master/Images/Function1/GithubMonitor.PNG)
 
### Create Second Azure Function
![Create Second Azure Function](https://github.com/camillebalima/AzureDemo/blob/master/Images/Function2/GithubMonitorWithClassesFunction.PNG)
### Publish to Microsoft Azure
![Publish to Microsoft Azure](https://github.com/camillebalima/AzureDemo/blob/master/Images/Publish1.PNG)
![Publish to Microsoft Azure](https://github.com/camillebalima/AzureDemo/blob/master/Images/FunctionsList.PNG)

### Copy URL (Do the same for both functions)
![Copy URL](https://github.com/camillebalima/AzureDemo/blob/master/Images/Github/Step3-1.PNG)
### Paste on Github (Do the same for both functions)
![Paste on Github](https://github.com/camillebalima/AzureDemo/blob/master/Images/Github/Step1.PNG)
![Paste on Github](https://github.com/camillebalima/AzureDemo/blob/master/Images/Github/Step2.PNG)
![Paste on Github](https://github.com/camillebalima/AzureDemo/blob/master/Images/Github/Step4.PNG)

### See Results After Push
* Function 1
![Function 1](https://github.com/camillebalima/AzureDemo/blob/master/Images/Function1/GithubMonitorAfter.PNG)
* Function 2
![Function 2](https://github.com/camillebalima/AzureDemo/blob/master/Images/Function2/GithubMonitorWithClasses.PNG)

# Conclusion
