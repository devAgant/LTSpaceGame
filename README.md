# LTHS Video Game Development Club
<img src="VideoGameClubBlackButton.png" alt="drawing" width="400"/>

## Introduction
<p>Hello programmers! Welcome to the main repository our club utilizes in order to contribute code and participate in an integraded collabarative coding experience.</p>

## Required Software
<p>In order to utilize this repository, there are a few applications you will be required to install. Below we have listed the required applications needed to contribute to this repository, as well as some optional programs.</p>

### Required:

Unity Student: 

https://unity.com/products/unity-student

<p>An IDE or Text Editor that operates as an IDE, Some Examples Below:
  
https://visualstudio.microsoft.com/downloads/
  
https://code.visualstudio.com/download</p>

Git Bash: 

https://git-scm.com/downloads

### Optional:

Notepad++:

https://notepad-plus-plus.org/downloads/

## Setting Up Unity Student
<p> At first, Unity Student can be a little overwhelming to download and install. This guide will assist you in installing Unity Student.</p>

### Verification of School Transcript:
<p> In order to download Unity Student, you must first submit a picture of your transcript to SheerID. When you submit the picture, make sure the picture includes your FULL NAME. Either edit your registration onto one image alongside your transcript from HAC, or request an unoffical transcript from Parchment. It does not matter how you get this image, just make sure it has both a TRANSCRIPT and a FULL NAME contained in the image, or else your request will be denied. The email you enter to send you the code once you have been approved does not have to be your school email, and can be any email you wish it to be. Your Unity account also can be registered under a personal email, this does not matter. After a few hours (or a few days), the Unity team will approve your request for the student edition of the program. Once you have been approved, check your email. Unity will email you a code with instructions to redeem the code. Redeem this code, download and install Unity Hub, and you are ready to go! </p>

## Setting Up GitHub
### IMPORTANT: Do This BEFORE Attempting to Contribute Code:
<p>Before beginning to contribute code to the project, you MUST enable SSH encryption for your GitHub account. This short tutorial will guide you through this process, so that you can begin to contribute code to the repository.</p>

### Git Bash Commands in Order to Setup SSH:
#### Note: These steps may vary on Linux, as Linux developers usually have their own way of doing things However, Linux users can also follow this guide if they wish to do so.
#### Note: If you are using macOS or Linux, you may need to update your SSH client or install a new SSH client prior to generating a new SSH key. For more information, refer to https://docs.github.com/en/authentication/connecting-to-github-with-ssh/generating-a-new-ssh-key-and-adding-it-to-the-ssh-agent
<p> The first few steps you will need to take can be done anywhere within the git bash. Open your git bash. Then, paste this command into the command line (Shift + Insert on Windows), and hit enter:
  
  **$ ls -al ~/.ssh**
  
 // Lists the files in your .ssh directory, if they exist
  
  This command will most likely tell you that the directory does not exist. Fortunatley, this is what we want. If you do have something here, you probably already know what you are doing.
  
  The next thig you need to do is create an SHH key for yourself, and set a password (passphrase) in order to access the repository from your PC. To create an SSH key, paste this command into the command line, replace "your_email@example.com" with the email you used to create your GitHub account, and hit enter:
  
  **$ ssh-keygen -t ed25519 -C "your_email@example.com"**
  
  When you're prompted to "Enter a file in which to save the key," press Enter. This accepts the default file location. The bash will then ask you to set a password (passphrase) which you will have to re-enter later in order to push and pull code from GitHub. The bash will show that you are not typing anything as you type the password, so don't get confused, just type the password and hit enter. The bash will then prompt you to retype the same password, where you must retype it and hit enter. After this, paste this command into the command line and hit enter:
  
  **$ eval "$(ssh-agent -s)"**
  
  This should show you an Agent pid. After this, Paste this command into the command line and hit enter:
  
  **$ ssh-add ~/.ssh/id_ed25519**
  
  And you are now finished! The next step is to add your SSH key to GitHub.</p>
  
  ### Linking your SSH to your GitHub Account:
  <p>Before exiting out of the Git bash, paste this command into the command line and hit enter:
  
  **$ clip < ~/.ssh/id_ed25519.pub**
  
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
  
  ### Testing your SSH connection to GitHub:
  <p> Open Git bash and paste the following command into the command line:
  
  **$ ssh -T git@github.com**
  
  You may see this prompt in your bash:
  
  > The authenticity of host 'github.com (IP ADDRESS)' can't be established.
  > RSA key fingerprint is SHA256:nThbg6kXUpJWGl7E1IGOCspRomTxdCARLviKw6E5SY8.
  > Are you sure you want to continue connecting (yes/no)?
  
  Verify that your SHA256 code matches the SHA256 code in the text above. If it does, then type 'yes' and hit enter. The message this should return should look like this:
  
  > Hi [username]! You've successfully authenticated, but GitHub does not
  > provide shell access.
  
  If this is the message you recieved, then you are all set and ready to add and commit to your local repository, and push changes to the GitHub! If you recieve a permission denied message, visit https://docs.github.com/en/articles/error-permission-denied-publickey</p>

## Commiting, Pushing, and Pulling To/From the Repository
<p> This tutorial will teach you how to use the Git bash in order to download the Unity project from GitHub and will also teach you how to upload your changes.</p>

#### Note: If you have already set this up, before every coding session, update your local repository by navigating to the project directory and running these commands:

  **$ git checkout master**
  
  **$ git pull origin master**
  
  #### You can then git checkout to each of your branches which you are working on and pull them as well, if other people are working on the same branch with you.
  
  ### Cloning the Repository:
  <p> In order to download the project, you must clone the project to a local folder on your PC. The first step is to make a folder on your PC in which you want to store the Unity Project. Make sure this folder is in a safe and permanent location. The next step is to open Git bash, and navigate to your folder in the terminal using the following command:
  
  **$ cd [FileDirectory]**
  
  Here is an example of this command:
  
  **$ cd C:\Users\devAgant\Unity\LTSpaceGame**
  
  Once you have located the directory in which you wish to clone the project to inside of the terminal, go to GitHub and copy this link from the repository homepage. Make sure the SSH option is selected:
  
  ![image](https://user-images.githubusercontent.com/68075877/138543395-8c7a8d78-19c0-4ba6-a07b-e415efc5f6c5.png)

  Then, take this link and paste it alongside this command into the Git bash terminal:
  
  **$ git clone [SSH Link]**
  
  You have now cloned the GitHub repository into your local repository.</p>
  
  ### Opening the cloned project in Unity:
  
  <p>In order to open the project you just cloned, open the Unity Hub application. Under the projects tab, click the dropdown arrow next to the Open button in the top right corner, and choose the "Add project from disk" option.</p>
  
  ![image](https://user-images.githubusercontent.com/68075877/138543457-03262963-74f2-4787-816e-c8abf866ab79.png)

  <p>Navigate to the file where you chose to clone the project from GitHub to, and select the folder. The project will now pop up in Unity, and you can make changes to it as you wish, without altering the GitHub repository.</p>
  
  ### Pushing Your Code to GitHub, and Creating a Pull Request:
  <p>Once you are done coding, you need to upload your code to GitHub in order for it to be reviewed and merged into the main branch. There are a few steps in order to do this. The first step is to navigate to your project directory in Git bash. To do this, run this command:

   **$ cd [FileDirectory]**
  
  Here is an example of this command:
  
  **$ cd C:\Users\devAgant\Unity\LTSpaceGame**
  
  Once you are in your project directory, run this command:
  
  **$ git checkout -b [yourFirstName]-[nameOfIssue/nameOfFeature]-[issueNumber/featureNumber]**
  
  Then, run this command:
  
  **$ git add .**
  
  After this command, you can then run this command in order to see what changes have been staged to commit to your local repository. This is an optional command.
  
  **$git status**
  
  Then, run this command in order to commit your code to your local repository.
  
  **$ git commit -m "[short message stating what changes you made]"**
  
  Finally, run this command:
  
  **git push -u origin [yourFirstName]-[nameOfIssue/nameOfFeature]-[issueNumber/featureNumber]**
  
  You have now pushed your code to the GitHub repository! However, there is one more step. In order to merge your code into the master branch, you must create a pull request. In order to do this, go to the GitHub repository on the website, and click on the branches tab:</p>
  
 ![image](https://user-images.githubusercontent.com/68075877/138543903-528659c4-ba26-4063-a910-2aea6fce66c6.png)

<p>Once you are here, you will see your branch, and a button next to it asking you to create a pull request. Click this button:</p>

![image](https://user-images.githubusercontent.com/68075877/138543964-f66f7ab7-dbcb-46f7-a32e-c960c1f03407.png)

<p>Create a title stating what the pull request is related to, and type any additional comments about the request:</p>

![image](https://user-images.githubusercontent.com/68075877/138544006-aa702e03-4b8f-49ce-9724-85d51b64b973.png)

<p>Add all the reviewers to the pull request by clicking the gear under the reviewers tab on the right side of the page:</p>

![image](https://user-images.githubusercontent.com/68075877/138544038-4f772579-efda-453c-b61e-b2dc67f4ed70.png)

<p>You are now done with everything you need to do on your part! The repository managers will now review your code, and merge it into the master branch at a later time. Once your pull request has been accepted, you can go back to the Git bash and delete your branch from your local repository by running these commands:

  **$ git checkout master**
  
  **$ git branch -D [yourFirstName]-[nameOfIssue/nameOfFeature]-[issueNumber/featureNumber]**
  
  You now know how to push code to the GitHub repository! Congrats!</p>

  
