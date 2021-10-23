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

###Optional:

Notepad++:

https://notepad-plus-plus.org/downloads/

## Setting Up Unity Student
<p> At first, Unity Student can be a little overwhelming to download and install. This guide will assist you in installing Unity Student.</p>

### Verification of School Transcript:
<p> In order to download Unity Student, you must first submit a picture of your transcript to SheerID. When you submit the picture, make sure the picture includes your FULL NAME. Either edit your registration onto one image alongside your transcript from HAC, or request an unoffical transcript from Parchment. It does not matter how you get this image, just make sure it has both a TRANSCRIPT and a FULL NAME contained in the image, or else your request will be denied. The email you enter to send you the code once you have been approved does not have to be your school email, and can be any email you wish it to be. Your Unity account also can be registered under a personal email, this does not matter. After a few hours (or a few days), the Unity team will approve your request for the student edition of the program. Once you have been approved, check your email. Unity will email you a code with instructions to redeem the code. Redeem this code, download and install Unity Hub, and you are ready to go! </p>

## Setting Up Github
### IMPORTANT: Do This BEFORE Attempting to Contribute Code:
<p>Before beginning to contribute code to the project, you MUSt enable SSH encryption for your github account. This short tutorial will guide you through this process, so that you can begin to contribute code to the repository.</p>

#Using Terminal to Commit to GitHub

You’ve got a few options to use this git commit command in the terminal code. Let’s have a look at them one by one.

  git commit -a

This will initiate the commit process to commit all changes in your current directory. But you will need to enter the commit message (i.e. the short description about the commit) separately. Your default text editor opens automatically on executing this command where you can enter the commit message.

  git commit -m “<commit message>”

If you wish to avoid an external prompt to enter the commit message while committing the desired changes to your local repository, use this command.

  git commit -am “<commit message>”

Running this command will commit all changes in the repository you’re currently working in, skipping the staging process, all the while including the descriptive commit message.

  git commit --amend “<commit message>”

With the help of this command, you can rewrite the last made commit with the latest staged changes (as a new commit).

Since these commits are made to the local repository, you must publish them to reflect them in the remote origin. This way all your teammates will be able to access the latest version of the code base. To do this, run the following command:

  git push <remote> <branch-name>
