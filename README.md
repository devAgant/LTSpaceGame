# LTHS Video Game Development Club
<img src="VideoGameClubBlackButton.png" alt="drawing" width="400"/>

## Introduction<a name="introduction"></a>
<p>Hello programmers! Welcome to the main repository our club utilizes in order to contribute code and participate in an integraded collabarative coding experience.</p>

## Table of contents
1. [Introduction](#introduction)
2. [Required Software](#requiredsoftware)
3. [Setting Up Unity Student](#unitystudent)
    1. [Verification of Student Transcript](#transcriptverification)
4. [Setting Up GitHub](#githubsetup)
    1. [Git Bash Commands in Order to Setup SSH](#gitbashcommands)
    2. [Linking Your SSH to Your GitHub Account](#linkingssh)
    3. [Testing Your SSH Connection to GitHub](#testingconnection)
5. [Commiting, Pushing, and Pulling To/From the Repository](#githubcommands)
    1. [Cloning the Repository](#cloningrepository)
    2. [Opening the Cloned Project in Unity](#openinginunity)
    3. [Pushing Your Code to GitHub](#pushingtogithub)
    4. [Creating a Pull Request](#pullrequests)
    5. [Using the GitHub Desktop App](#githubdesktop)
6. [Workflow Guide](#workflowguide)
    1. [Creating an Issue](#creatingissue)
    2. [Labelling an Issue](#labellingissue)
    3. [Assigning an Issue](#assigningissue)
    4. [Closing an Issue](#closingissue)
    5. [Using the Project Board](#projectboard)

## Required Software<a name="requiredsoftware"></a>
<p>In order to utilize this repository, there are a few applications you will be required to install. Below we have listed the required applications needed to contribute to this repository, as well as some optional programs.</p>

### Required:

Unity Student: 

https://unity.com/products/unity-student

Unity Hub:

https://unity3d.com/get-unity/download

<p>An IDE or Text Editor that operates as an IDE, Some Examples Below:
  
https://visualstudio.microsoft.com/downloads/
  
https://code.visualstudio.com/download</p>

Git Bash: 

https://git-scm.com/downloads

### Optional:

Notepad++:

https://notepad-plus-plus.org/downloads/

## Setting Up Unity Student<a name="unitystudent"></a>
<p> At first, Unity Student can be a little overwhelming to download and install. This guide will assist you in installing Unity Student.</p>

### Verification of School Transcript: <a name="transcriptverification"></a>
<p> In order to download Unity Student, you must first submit a picture of your transcript to SheerID. When you submit the picture, make sure the picture includes your FULL NAME. Either edit your registration onto one image alongside your transcript from HAC, or request an unoffical transcript from Parchment. It does not matter how you get this image, just make sure it has both a TRANSCRIPT and a FULL NAME contained in the image, or else your request will be denied. The email you enter to send you the code once you have been approved does not have to be your school email, and can be any email you wish it to be. Your Unity account also can be registered under a personal email, this does not matter. After a few hours (or a few days), the Unity team will approve your request for the student edition of the program. Once you have been approved, check your email. Unity will email you a code with instructions to redeem the code. Redeem this code, download and install Unity Hub, and you are ready to go! </p>

## Setting Up GitHub<a name="githubsetup"></a>
### IMPORTANT: Do This BEFORE Attempting to Contribute Code:
<p>Before beginning to contribute code to the project, you MUST enable SSH encryption for your GitHub account. This short tutorial will guide you through this process, so that you can begin to contribute code to the repository.</p>

### Git Bash Commands in Order to Setup SSH: <a name="gitbashcommands"></a>
#### Note: These steps may vary on Linux, as Linux developers usually have their own way of doing things. However, Linux users can also follow this guide if they wish to do so.
#### Note: If you are using macOS or Linux, you may need to update your SSH client or install a new SSH client prior to generating a new SSH key. For more information, refer to https://docs.github.com/en/authentication/connecting-to-github-with-ssh/generating-a-new-ssh-key-and-adding-it-to-the-ssh-agent
<p> The first few steps you will need to take can be done anywhere within the git bash. Open your git bash. Then, paste this command into the command line (Shift + Insert on Windows), and hit enter:
  
  `$ ls -al ~/.ssh`
  
 // Lists the files in your .ssh directory, if they exist
  
  This command will most likely tell you that the directory does not exist. Fortunatley, this is what we want. If you do have something here, you probably already know what you are doing.
  
  The next thig you need to do is create an SHH key for yourself, and set a password (passphrase) in order to access the repository from your PC. To create an SSH key, paste this command into the command line, replace "your_email@example.com" with the email you used to create your GitHub account, and hit enter:
  
  `$ ssh-keygen -t ed25519 -C "your_email@example.com"`
  
  When you're prompted to "Enter a file in which to save the key," press Enter. This accepts the default file location. The bash will then ask you to set a password (passphrase) which you will have to re-enter later in order to push and pull code from GitHub. The bash will show that you are not typing anything as you type the password, so don't get confused, just type the password and hit enter. The bash will then prompt you to retype the same password, where you must retype it and hit enter. After this, paste this command into the command line and hit enter:
  
  `$ eval "$(ssh-agent -s)"`
  
  This should show you an Agent pid. After this, Paste this command into the command line and hit enter:
  
  `$ ssh-add ~/.ssh/id_ed25519`
  
  And you are now finished! The next step is to add your SSH key to GitHub.</p>
  
  ### Linking Your SSH to Your GitHub Account:<a name="linkingssh"></a>
  <p>Before exiting out of the Git bash, paste this command into the command line and hit enter:
  
  `$ clip < ~/.ssh/id_ed25519.pub`
  
  This will copy your SSH info to your clipboard. (Tip: If clip is not working, you can locate the hidden .ssh folder, open the file in your favorite text editor, and copy it to your clipboard.) After you have copied your SSH info, go to the GitHub website. In the upper-right corner of any page, click your profile photo, then click Settings.</p>
  
  <img src="https://user-images.githubusercontent.com/68075877/138542884-d2e6efd7-5734-4e09-b88f-4057c2b4b115.png" alt="guide-image" width="200"/>
    
  <p>In the user settings sidebar, click SSH and GPG keys.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/settings-sidebar-ssh-keys.png" alt="guide-image" width="200"/>
  
  <p>Click New SSH key or Add SSH key.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/ssh-add-ssh-key.png" alt="guide-image" width="300"/>
  
  In the "Title" field, add a descriptive label for the new key. For example, if you're using a personal Mac, you might call this key "Personal MacBook Air". Paste your key into the "Key" field.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/ssh-key-paste.png" alt="guide-image" width="500"/>
  
  <p>Click Add SSH key.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/ssh-add-key.png" alt="guide-image" width="200"/>
  
  <p>Congratgulations! You have now finished setting up SSH for GitHub. There is only one step left now: Testing your SSH connection.</p>
  
  ### Testing Your SSH Connection to GitHub: <a name="testingconnection"></a>
  <p> Open Git bash and paste the following command into the command line:
  
  `$ ssh -T git@github.com`
  
  You may see this prompt in your bash:
  
  > The authenticity of host 'github.com (IP ADDRESS)' can't be established.
  > RSA key fingerprint is SHA256:nThbg6kXUpJWGl7E1IGOCspRomTxdCARLviKw6E5SY8.
  > Are you sure you want to continue connecting (yes/no)?
  
  Verify that your SHA256 code matches the SHA256 code in the text above. If it does, then type 'yes' and hit enter. The message this should return should look like this:
  
  > Hi [username]! You've successfully authenticated, but GitHub does not
  > provide shell access.
  
  If this is the message you recieved, then you are all set and ready to add and commit to your local repository, and push changes to the GitHub! If you recieve a permission denied message, visit https://docs.github.com/en/articles/error-permission-denied-publickey</p>

## Commiting, Pushing, and Pulling To/From the Repository<a name="githubcommands"></a>
<p> This tutorial will teach you how to use the Git bash in order to download the Unity project from GitHub and will also teach you how to upload your changes.</p>

#### Note: If you have already set this up, before every coding session, update your local repository by navigating to the project directory and running these commands:
<p>
    
  `$ git checkout master`
  
  `$ git pull origin master`
    
  </p>
  #### You can then git checkout to each of your branches which you are working on and pull them as well, if other people are working on the same branch with you.
  
  ### Cloning the Repository: <a name="cloningrepository"></a>
  <p> In order to download the project, you must clone the project to a local folder on your PC. The first step is to make a folder on your PC in which you want to store the Unity Project. Make sure this folder is in a safe and permanent location. The next step is to open Git bash, and navigate to your folder in the terminal using the following command:
  
  `$ cd [FileDirectory]`
  
  Here is an example of this command:
  
  `$ cd C:/Users/devAgant/Unity/LTSpaceGame`</p>
    
   #### Note: make sure to use a forward slash (/) in the terminal, and not a backslash (\\). If you use a backslash, this will not work!
  
  <p>Once you have located the directory in which you wish to clone the project to inside of the terminal, go to GitHub and copy this link from the repository homepage. Make sure the SSH option is selected:</p>
  
  ![image](https://user-images.githubusercontent.com/68075877/138543395-8c7a8d78-19c0-4ba6-a07b-e415efc5f6c5.png)

  <p>Then, take this link and paste it alongside this command into the Git bash terminal:
  
  `$ git clone [SSH Link]`
  
  You have now cloned the GitHub repository into your local repository.</p>
  
  ### Opening the Cloned Project in Unity:<a name="openinginunity"></a>
  
  <p>In order to open the project you just cloned, open the Unity Hub application. Under the projects tab, click the dropdown arrow next to the Open button in the top right corner, and choose the "Add project from disk" option.</p>
  
  ![image](https://user-images.githubusercontent.com/68075877/138543457-03262963-74f2-4787-816e-c8abf866ab79.png)

  <p>Navigate to the file where you chose to clone the project from GitHub to, and select the folder. The project will now pop up in Unity, and you can make changes to it as you wish, without altering the GitHub repository.</p>
  
  ### Pushing Your Code to GitHub:<a name="pushingtogithub"></a>
  <p>Once you are done coding, you need to upload your code to GitHub in order for it to be reviewed and merged into the main branch. There are a few steps in order to do this. The first step is to navigate to your project directory in Git bash. To do this, run this command:

   `$ cd [FileDirectory]`
  
  Here is an example of this command:
  
  `$ cd C:/Users/devAgant/Unity/LTSpaceGame`</p>
    
   #### Note: make sure to use a forward slash (/) in the terminal, and not a backslash (\\). If you use a backslash, this will not work!
  
  <p>Once you are in your project directory, run this command:
  
  `$ git checkout -b [yourFirstName]-[nameOfIssue/nameOfFeature]-[issueNumber/featureNumber]`
  
  Then, run this command:
  
  `$ git add .`
  
  After this command, you can then run this command in order to see what changes have been staged to commit to your local repository. This is an optional command.
  
  `$git status`
  
  Then, run this command in order to commit your code to your local repository.
  
  `$ git commit -m "[short message stating what changes you made]"`
  
  If this is your first time ever using git, you may need to add your GitHub email to git. If you get a message saying "Author identity unkown" then run this command:
    
  `$ git config user.email "[your email]"`
    
  Then, run the commit command again (only if you got the error). Finally, run this command:
  
  `git push -u origin [yourFirstName]-[nameOfIssue/nameOfFeature]-[issueNumber/featureNumber]`
  
  You have now pushed your code to the GitHub repository! However, there is one more step. </p>
    
  ### Creating a Pull Request:<a name="pullrequests"></a>
  
  <p>In order to merge your code into the master branch, you must create a pull request. In order to do this, go to the GitHub repository on the website, and click on the branches tab:</p>
  
 ![image](https://user-images.githubusercontent.com/68075877/138543903-528659c4-ba26-4063-a910-2aea6fce66c6.png)

<p>Once you are here, you will see your branch, and a button next to it asking you to create a pull request. Click this button:</p>

![image](https://user-images.githubusercontent.com/68075877/138543964-f66f7ab7-dbcb-46f7-a32e-c960c1f03407.png)

<p>Create a title stating what the pull request is related to, and type any additional comments about the request:</p>

![image](https://user-images.githubusercontent.com/68075877/138544006-aa702e03-4b8f-49ce-9724-85d51b64b973.png)

<p>Finally, submit the pull request. You are now done with everything you need to do on your part! The repository managers will now review your code, and merge it into the master branch at a later time. Once your pull request has been accepted, you can go back to the Git bash and delete your branch from your local repository by running these commands:

  `$ git checkout master`
  
  `$ git branch -D [yourFirstName]-[nameOfIssue/nameOfFeature]-[issueNumber/featureNumber]`
  
  You now know how to push code to the GitHub repository! Congrats!</p>
  
  ### Using the GitHub Desktop App:<a name="githubdesktop"></a>
  
  <p>Alternatively, you can use the GitHub desktop app to push, pull, and commit to Git and GitHub. In order to setup the GitHub desktop app, first open the app. If you have already made a repository from the previous steps, click the "Add an existing repository" button. If not, click the clone repository button. Then, choose the file directory in which your Unity project is located. The app will automatically load the repository, and provide a user interface which can be used to perform the commands which you learned how to use in the tutorial above with ease.</p>

  ## Workflow Guide<a name="workflowguide"></a>
  
  <p>This tutorial will show you how this repository is organized, and will demonstrate how to use the features we have set up in order for our team to organize our work. You will learn how to create issues, label issues, assign issues, close issues, and most importantly, how to use the project board.</p>
  
  ### Creating an Issue:<a name="creatingissue"></a>
  
  <p> In the case you find a bug in our code, you will want to create an issue stating that a bug was found on the website. To do this, the first step is to navigate to the Issues tab in the repository.</p>
    
![image](https://user-images.githubusercontent.com/68075877/138567025-df845113-5f32-48c3-a307-8809bf8494c8.png)

<p>Once you are here, you can create an issue by pressing the green "New issue" button.</p>

![image](https://user-images.githubusercontent.com/68075877/138567054-0a7c17dd-d613-402b-9847-9b348b3594c6.png)

<p>Enter the name of the issue into the titlebox, and provide a description as to what the issue is. If the issue is a bug, you may want to specify where exactly in the code the bug is present, or if the location of the bug is unknown, state what exactly the bug is. After you are done creating your issue, click the green "Submit new issue" button.</p>

![image](https://user-images.githubusercontent.com/68075877/138567165-bc80ed81-ae1b-491f-8b98-d74817642ccb.png)

<p>You have now created an issue! Make sure to label the issue so that other collaborators can differentiate your issue from a new feature request.</p>

### Labelling an Issue:<a name="labellingissue"></a>

<p>There are two ways to label your issue. The first is to label it while you are creating the issue (this method is much better because then you can do this in one step). Alternatively, you can also navigate to issues tab, find your newly created issue, select it, and assign a label. In order to assign a label during the creation of an issue, click on the word "Labels" on the right side of the issue creation panel.</p>

![image](https://user-images.githubusercontent.com/68075877/138567473-bd5a5994-521c-4238-9c01-d5919ac514ff.png)

<p>You can now assign the labels you need, and continue creating the issue as normal.</p>

<p>However, what if you forgot to assign a label to the issue? To fix this, head over to the Issues tab in the repository.</p>

![image](https://user-images.githubusercontent.com/68075877/138567025-df845113-5f32-48c3-a307-8809bf8494c8.png)

<p>Find your issue, and select it by clicking the checkbox.</p>

![image](https://user-images.githubusercontent.com/68075877/138567543-4110bed1-920b-4c73-8be5-d0361163f9f4.png)

<p>Click on the "Label" dropdown, and choose the appropriate label for the issue.</p>

![image](https://user-images.githubusercontent.com/68075877/138567576-9e41ffef-a75a-461b-84f2-737a43abaad4.png)

<p>You have now successfully labelled your issue!</p>

### Assigning an Issue:<a name="assigningissue"></a>

<p>Similar to labelling, there are also two ways to assign your issue. The first is to assign it while you are creating the issue. Alternatively, you can also navigate to issues tab, find your newly created issue, select it, and assign it from there. In order to assign an issue during its creation, click on the word "Assignees" on the right side of the issue creation panel.</p>

![image](https://user-images.githubusercontent.com/68075877/138567672-43cf9571-98b7-477a-8b9b-28525555d067.png)

<p>You can now assign the issue, and continue creating the issue as normal.</p>

<p>However, what if you want to assign an existing issue to yourself, such as a new feature request, in order to begin working on it? To do this, head over to the Issues tab in the repository.</p>

![image](https://user-images.githubusercontent.com/68075877/138567025-df845113-5f32-48c3-a307-8809bf8494c8.png)

<p>Find your issue, and select it by clicking the checkbox.</p>

![image](https://user-images.githubusercontent.com/68075877/138567543-4110bed1-920b-4c73-8be5-d0361163f9f4.png)

<p>Click on the "Assign" dropdown, and choose your name.</p>

![image](https://user-images.githubusercontent.com/68075877/138567748-047f64c7-bfba-4c63-9aa4-2e9366ce4e34.png)

<p>And boom! you can now begin working on the issue.</p>

### Closing an Issue:<a name="closingissue"></a>

<p>Once your pull request has been approved, you will want to close your issue to indicate to other collaborators that you have finished working on that issue. In order to do this, head over to the Issues tab in the repository.</p>

![image](https://user-images.githubusercontent.com/68075877/138567025-df845113-5f32-48c3-a307-8809bf8494c8.png)

<p>Find your issue, and select it by clicking the checkbox.</p>

![image](https://user-images.githubusercontent.com/68075877/138567543-4110bed1-920b-4c73-8be5-d0361163f9f4.png)

<p>Click on the "Mark as" dropdown and choose the closed option.</p>

![image](https://user-images.githubusercontent.com/68075877/138567886-68253cfd-c706-486a-9fc0-3628d8fb6488.png)

<p>Alternatively, you can find your issue through the project board and select it, and then click the close issue button found there.</p>

![image](https://user-images.githubusercontent.com/68075877/138567945-031693c5-01a6-481e-9cb0-cec93748f22d.png)

<p>You have now successfully closed your issue! Congratulations on finishing your work!</p>

### Using the Project Board:<a name="projectboard"></a>

<p>The project board is an extremely useful tool you can use to quickly assign, label, and close issues. You can also view all of the issues currently being worked on, as well as all the current pull requests and completed issues. To navigate to the project board, Head over to the Projects tab in the repository.</p>

![image](https://user-images.githubusercontent.com/68075877/138568045-871d5d90-496b-4558-90fe-c36353e0ad99.png)

<p>From here, click on the "Project Board" project in order to access the board.</p>

![image](https://user-images.githubusercontent.com/68075877/138568082-b9b1cf01-3232-404a-aa04-50126b232b09.png)

<p>You have now successfully navigated to the project board! If you wish to modify an issue, click on the issue and modify what needs to be changed in the panel that appears to the right side of your screen.</p>

![image](https://user-images.githubusercontent.com/68075877/138567945-031693c5-01a6-481e-9cb0-cec93748f22d.png)

<p>And that's all there is when it comes to the workflow of our repository. You are now fully prepared and ready to contribute code to the repository in an organized manner. Good luck!</p>
