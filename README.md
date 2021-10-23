# LTHS Videogame Development Club
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
  
  $ ls -al ~/.ssh
- Lists the files in your .ssh directory, if they exist
  
  This command will most likely tell you that the directory does not exist. Fortunatley, this is what we want. If you do have something here, you probably already know what you are doing.
  
  The next thig you need to do is create an SHH key for yourself, and set a password (passphrase) in order to access the repository from your PC. To create an SSH key, paste this command into the command line, replace "your_email@example.com" with the email you used to create your GitHub account, and hit enter:
  
  $ ssh-keygen -t ed25519 -C "your_email@example.com"
  
  When you're prompted to "Enter a file in which to save the key," press Enter. This accepts the default file location. The bash will then ask you to set a password (passphrase) which you will have to re-enter later in order to push and pull code from GitHub. The bash will show that you are not typing anything as you type the password, so don't get confused, just type the password and hit enter. The bash will then prompt you to retype the same password, where you must retype it and hit enter. After this, paste this command into the command line and hit enter:
  
  $ eval "$(ssh-agent -s)"
  
  This should show you an Agent pid. After this, Paste this command into the command line and hit enter:
  
  $ ssh-add ~/.ssh/id_ed25519
  
  And you are now finished! The next step is to add your SSH key to GitHub.</p>
  
  ### Linking your SSH to your GitHub Account:
  <p>Before exiting out of the Git bash, paste this command into the command line and hit enter:
  
  $ clip < ~/.ssh/id_ed25519.pub
  
  This will copy your SSH info to your clipboard. (Tip: If clip is not working, you can locate the hidden .ssh folder, open the file in your favorite text editor, and copy it to your clipboard.) After you have copied your SSH info, go to the GitHub website. In the upper-right corner of any page, click your profile photo, then click Settings.</p>
  
  <img src="https://user-images.githubusercontent.com/68075877/138542884-d2e6efd7-5734-4e09-b88f-4057c2b4b115.png" alt="guide-image" width="200"/>
    
  <p>In the user settings sidebar, click SSH and GPG keys.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/settings-sidebar-ssh-keys.png" alt="guide-image" width="200"/>
  
  <p>Click New SSH key or Add SSH key.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/ssh-add-ssh-key.png" alt="guide-image" width="200"/>
  
  In the "Title" field, add a descriptive label for the new key. For example, if you're using a personal Mac, you might call this key "Personal MacBook Air". Paste your key into the "Key" field.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/ssh-key-paste.png" alt="guide-image" width="200"/>
  
  <p>Click Add SSH key.</p>
  
  <img src="https://docs.github.com/assets/images/help/settings/ssh-add-key.png" alt="guide-image" width="200"/>
  
  
  

